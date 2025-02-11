﻿using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Video;

namespace WI
{
    public static partial class FieldBinder
    {
        public class Model
        {
            object origin;
            Type originType;
            public Model(in object o)
            {
                origin = o;
                originType = o.GetType();
            }

            class fieldContainer
            {
                public FieldInfo info;
                public object value;
                public Action changeEvent;
            }
            
            Dictionary<string, fieldContainer> fieldTable = new();
            public Model Binding(in string targetField, Action changeEvent)
            {
                if(!fieldTable.TryGetValue(targetField, out var fi))
                {
                    var fieldInfo = originType.GetField(targetField, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (fieldInfo == null)
                    {
                        Debug.LogError($"Not Found {targetField}.");
                        return null;
                    }
                    var value = fieldInfo.GetValue(origin);
                    fi = new fieldContainer()
                    {
                        info = fieldInfo,
                        value = value,
                    };
                    fieldTable.Add(targetField, fi);
                }
                fi.changeEvent += changeEvent;
                return this;
            }

            public void CheckChange()
            {
                foreach(var f in fieldTable)
                {
                    var curr = f.Value.info.GetValue(origin);
                    if (f.Value.value.Equals(curr))
                        continue;
                    fieldTable[f.Key].value = curr;
                    f.Value.changeEvent?.Invoke();
                }
            }
        }
        static Dictionary<object, Model> models = new Dictionary<object, Model>();
        static FieldBinder()
        {
            models.Clear();
        }

        public static void Update()
        {
            foreach(var m in models)
            {
                m.Value.CheckChange();
            }
        }
        public static Model Regist(in object o)
        {
            if(models.TryGetValue(o, out var mo))
            {
                return mo;
            }
            var model = new Model(o);
            models.Add(o,model);
            return model;
        }
        public static void Unregist(in object o)
        {
            models.Remove(o);
        }
    }
}
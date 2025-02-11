﻿using System;
using UnityEngine.UI;
using static UnityEngine.UI.Button;

namespace WI
{
    public abstract class PanelBase : BaseUI
    {

    }

    public static class PanelBaseExtension
    {
        public static void SetActive(this PanelBase[] pbs, bool value)
        {
            foreach(var p in pbs)
            {
                p.gameObject.SetActive(value);
            }
        }
        public static void SetActive(this PanelBase[] pbs, bool value, int count)
        {
            for (int i = 0; i < count; ++i)
            {
                pbs[i].gameObject.SetActive(value);
            }
        }
    }

}
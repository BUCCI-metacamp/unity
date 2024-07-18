using System.Collections.Generic;
using UnityEngine;

namespace Edukit
{
    public class Conveyor : SubMachine
    {
        public string TotalDistance;
        public string RevPerSecond;
        public string Velocity;

        public bool realSpeed;
        public float speed;
        public float fullSpeed;
        [SerializeField]
        MeshRenderer mr;
        public Transform startPoint;
        public Transform endPoint;

        public bool isAnim;

        Vector3 conveyorDir
        {
            get
            {
                return (endPoint.position - startPoint.position).normalized;
            }
        }

        private new void Awake()
        {
            base.Awake();
            mr = GetComponent<MeshRenderer>();
        }

        public float prevMoveLength;
        public float currentMoveLength;
        public float conveyorSpeed;
        protected override void VariableUpdateEvent(string variableName, string variableValue)
        {
            if (!isAnim)
                return;
            switch (variableName)
            {
                case nameof(TotalDistance):

                    float temp = this.speed;
                    if (realSpeed)
                    {
                        float currentDistance = float.Parse(variableValue) * 0.166f;
                        currentMoveLength = currentDistance - prevMoveLength;
                        prevMoveLength = currentDistance;
                        var speed = (currentMoveLength / 1000f);
                        this.speed = speed;
                    }
                    else
                    {
                        this.speed /= 1000f;
                    }
                    
                    Running(speed);
                    conveyorSpeed = speed * 3.2f;
                    var u = mr.material.GetTextureOffset("_BaseMap");
                    u.x -= conveyorSpeed;
                    mr.material.SetTextureOffset("_BaseMap", u);
                    this.speed = temp;
                    break;
            }

        }

        void Running(float speed)
        {
            foreach (var c in onRailChipList)
            {
                if (c.onHand)
                    continue;
                var dir = conveyorDir;

                var pos = c.transform.position;
                pos += dir * speed;
                c.transform.position = pos;
            }
        }

        public void AnimState(bool value)
        {
            isAnim = value;
        }
        public void ChangeConveyorSpeed(float value)
        {
            speed = fullSpeed * (value);
        }

        List<EdukitChip> onRailChipList = new();
        private void OnTriggerEnter(Collider other)
        {
            if (!other.TryGetComponent<EdukitChip>(out var ec))
                return;
            onRailChipList.Add(ec);
        }
        private void OnTriggerExit(Collider other)
        {
            if (!other.TryGetComponent<EdukitChip>(out var ec))
                return;
            onRailChipList.Remove(ec);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Edukit
{
    public class EdukitChip : MonoBehaviour
    {
        public enum State
        {
            Unknown,
            Red,
            White,
        }

        public State currentState;

        MeshRenderer mr;
        public Material mat_Red;
        public Material mat_White;
        public Material mat_Unknown;
        public Transform dicePos;
        internal bool isSensing;

        private void Awake()
        {
            mr = GetComponent<MeshRenderer>();
            isSensing = false;
        }

        public void SetState(State s)
        {
            switch (s)
            {
                case State.Unknown:
                    mr.material = mat_Unknown;
                    break;
                case State.Red:
                    mr.material = mat_Red;
                    break;
                case State.White:
                    mr.material = mat_White;
                    break;
            }
            currentState = s;
        }

        public bool onHand;
        public void OnGrab(Transform grabPoint)
        {
            onHand = true;
            transform.position = grabPoint.position;
            transform.SetParent(grabPoint);
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic= true;
        }

        internal void SetDice(EdukitDice frontDice)
        {
            frontDice.transform.SetParent(transform);
            frontDice.transform.position = dicePos.position;
        }

        internal void HandOff()
        {
            transform.SetParent(null);
            GetComponent<Collider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
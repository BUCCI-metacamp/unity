using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using WI;

namespace Edukit
{
    public class Panel_M1 : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI No1PowerState;
        public TextMeshProUGUI No1DelayTime;
        public TextMeshProUGUI No1Push;
        public TextMeshProUGUI No1Count;
        public TextMeshProUGUI No1ChipFull;

        protected override void OnVariableChange(string variableName, string value)
        {
            switch(variableName)
            {
                case nameof(No1PowerState):
                    No1PowerState.SetText(value);
                    break;

                case nameof(No1DelayTime):
                    No1DelayTime.SetText(value);
                    break;

                case nameof(No1Push):
                    No1Push.SetText(value);
                    break;

                case nameof(No1Count):
                    No1Count.SetText(value);
                    break;

                case nameof(No1ChipFull):
                    No1ChipFull.SetText(value);
                    break;
            }
        }
    }
}
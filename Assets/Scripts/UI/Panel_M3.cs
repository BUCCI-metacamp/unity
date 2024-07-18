using TMPro;
using WI;

namespace Edukit
{
    public class Panel_M3 : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI No3ChipArrival;
        public TextMeshProUGUI No3PowerState;
        public TextMeshProUGUI No3Count;
        public TextMeshProUGUI No3Motor1Position;
        public TextMeshProUGUI No3Motor2Position;
        public TextMeshProUGUI No3Gripper;
        public TextMeshProUGUI No3Motor1Action;
        public TextMeshProUGUI No3Motor2Action;

        protected override void OnVariableChange(string variableName, string value)
        {
            switch(variableName)
            {
                case nameof(No3ChipArrival):
                    No3ChipArrival.SetText(value);
                    break;
                case nameof(No3PowerState):
                    No3PowerState.SetText(value);
                    break;
                case nameof(No3Count):
                    No3Count.SetText(value);
                    break;
                case nameof(No3Motor1Position):
                    No3Motor1Position.SetText(value);
                    break;
                case nameof(No3Motor2Position):
                    No3Motor2Position.SetText(value);
                    break;
                case nameof(No3Gripper):
                    No3Gripper.SetText(value);
                    break;
                case nameof(No3Motor1Action):
                    No3Motor1Action.SetText(value);
                    break;
                case nameof(No3Motor2Action):
                    No3Motor2Action.SetText(value);
                    break;
            }
        }
    }
}
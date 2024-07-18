using TMPro;
using WI;

namespace Edukit
{
    public class Panel_M2 : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI No2Standby;
        public TextMeshProUGUI No2SensingMemory;
        public TextMeshProUGUI No2PowerState;
        public TextMeshProUGUI No2Count;
        public TextMeshProUGUI No2Chip;
        public TextMeshProUGUI No2CubeFull;
        public TextMeshProUGUI No2InPoint;
        public TextMeshProUGUI No2OutPoint;
        public TextMeshProUGUI No2Sol;
        public TextMeshProUGUI No2SolAction;
        public TextMeshProUGUI No2BackToSquare;
        public TextMeshProUGUI No2OperationMode;
        protected override void OnVariableChange(string variableName, string value)
        {
            switch(variableName)
            {
                case nameof(No2Standby):
                    No2Standby.SetText(value);
                    break;
                case nameof(No2SensingMemory):
                    No2SensingMemory.SetText(value);
                    break;
                case nameof(No2PowerState):
                    No2PowerState.SetText(value);
                    break;
                case nameof(No2Count):
                    No2Count.SetText(value);
                    break;
                case nameof(No2Chip):
                    No2Chip.SetText(value);
                    break;
                case nameof(No2CubeFull):
                    No2CubeFull.SetText(value);
                    break;
                case nameof(No2InPoint):
                    No2InPoint.SetText(value);
                    break;
                case nameof(No2OutPoint):
                    No2OutPoint.SetText(value);
                    break;
                case nameof(No2Sol):
                    No2Sol.SetText(value);
                    break;
                case nameof(No2SolAction):
                    No2SolAction.SetText(value);
                    break;
                case nameof(No2BackToSquare):
                    No2BackToSquare.SetText(value);
                    break;
                case nameof(No2OperationMode):
                    No2OperationMode.SetText(value);
                    break;
            }
        }
    }
}
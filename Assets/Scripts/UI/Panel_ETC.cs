using TMPro;
using WI;

namespace Edukit
{
    public class Panel_ETC : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI StartState;
        public TextMeshProUGUI ResetState;
        public TextMeshProUGUI EmergencyState;
        public TextMeshProUGUI InputLimit;
        public TextMeshProUGUI DataTime;

        protected override void OnVariableChange(string variableName, string value)
        {
            switch(variableName)
            {
                case nameof(StartState):
                    StartState.SetText(value);
                    break;

                case nameof(ResetState):
                    ResetState.SetText(value);
                    break;

                case nameof(EmergencyState):
                    EmergencyState.SetText(value);
                    break;

                case nameof(InputLimit):
                    InputLimit.SetText(value);
                    break;

                case nameof(DataTime):
                    DataTime.SetText(value);
                    break;
            }
        }
    }
}
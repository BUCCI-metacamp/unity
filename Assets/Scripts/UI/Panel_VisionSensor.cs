using TMPro;
using WI;

namespace Edukit
{
    public class Panel_VisionSensor : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI Sen2PowerState;
        public TextMeshProUGUI DiceValue;
        public TextMeshProUGUI DiceComparisonValue;

        protected override void OnVariableChange(string variableName, string value)
        {
            switch(variableName)
            {
                case nameof(Sen2PowerState):
                    Sen2PowerState.SetText(value);
                    break;
                    
                case nameof(DiceValue):
                    DiceValue.SetText(value);
                    break;

                case nameof(DiceComparisonValue):
                    DiceComparisonValue.SetText(value);
                    break;
            }
        }
    }
}
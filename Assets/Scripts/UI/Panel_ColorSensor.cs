using TMPro;
using WI;

namespace Edukit
{
    public class Panel_ColorSensor : EdukitDashboard, ISingle
    {
        public TextMeshProUGUI Sen1PowerState;
        public TextMeshProUGUI ColorSensorSensing;

        protected override void OnVariableChange(string variableName, string value)
        {
            switch (variableName)
            {
                case nameof(Sen1PowerState):
                    Sen1PowerState.SetText(value);
                    break;

                case nameof(ColorSensorSensing):
                    ColorSensorSensing.SetText(value);
                    break;
            }
        }
    }

}
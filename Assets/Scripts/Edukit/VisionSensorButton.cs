using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class VisionSensorButton : MonoBehaviour
{
    public event Action<int, string> onVisionSensorButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button visionSensorButton = GameObject.Find("visionSensorState").GetComponent<Button>();
        if (visionSensorButton != null)
        {
            visionSensorButton.onClick.AddListener(OnButtonPressed);
        }

    }
    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onVisionSensorButtonChanged?.Invoke(5, "1");
        onVisionSensorButtonChanged?.Invoke(5, "0");
    }
}

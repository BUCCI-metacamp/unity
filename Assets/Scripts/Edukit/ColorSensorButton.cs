using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class ColorSensorButton : MonoBehaviour
{
    public event Action<int, string> onColorSensorButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button colorSensorButton = GameObject.Find("colorSensorState").GetComponent<Button>();
        if (colorSensorButton != null)
        {
            colorSensorButton.onClick.AddListener(OnButtonPressed);
        }

    }

    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onColorSensorButtonChanged?.Invoke(4, "1");
        onColorSensorButtonChanged?.Invoke(4, "0");
    }
}

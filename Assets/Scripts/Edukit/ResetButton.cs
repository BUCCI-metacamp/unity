using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public event Action<int, string> onResetButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button resetButton = GameObject.Find("resetState").GetComponent<Button>();
        if (resetButton != null)
        {
            resetButton.onClick.AddListener(OnButtonPressed);
        }

    }

    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onResetButtonChanged?.Invoke(3, "1");
        onResetButtonChanged?.Invoke(3, "0");
    }
}

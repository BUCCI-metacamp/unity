using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public event Action<int, string> onStartButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button startButton = GameObject.Find("startState").GetComponent<Button>();
        if (startButton != null)
        {
            startButton.onClick.AddListener(OnButtonPressed);
        }

    }
    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onStartButtonChanged?.Invoke(1, "1");
        onStartButtonChanged?.Invoke(1, "0");
    }
}

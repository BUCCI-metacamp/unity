using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class No2Button : MonoBehaviour
{
    public event Action<int, string> onNo2ButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button no2Button = GameObject.Find("no2State").GetComponent<Button>();
        if (no2Button != null)
        {
            no2Button.onClick.AddListener(OnButtonPressed);
        }

    }

    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onNo2ButtonChanged?.Invoke(7, "1");
        onNo2ButtonChanged?.Invoke(7, "0");
    }
}

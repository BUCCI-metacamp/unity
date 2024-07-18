using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class No1Button : MonoBehaviour
{
    public event Action<int, string> onNo1ButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button no1Button = GameObject.Find("no1State").GetComponent<Button>();
        if (no1Button != null)
        {
            no1Button.onClick.AddListener(OnButtonPressed);
        }

    }
    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onNo1ButtonChanged?.Invoke(6, "1");
        onNo1ButtonChanged?.Invoke(6, "0");
    }
}

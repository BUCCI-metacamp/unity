using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Best.MQTT;
using UnityEngine.UI;

public class No3Button : MonoBehaviour
{
    public event Action<int, string> onNo3ButtonChanged; //int: tagId, string: value
    public Mqtt mqtt;
    void Start()
    {
        Button no3Button = GameObject.Find("no3State").GetComponent<Button>();
        if (no3Button != null)
        {
            no3Button.onClick.AddListener(OnButtonPressed);
        }

    }

    void OnButtonPressed() //버튼이 눌렸을 때 이밴트 발생
    {
        onNo3ButtonChanged?.Invoke(8, "1");
        onNo3ButtonChanged?.Invoke(8, "0");
    }
}

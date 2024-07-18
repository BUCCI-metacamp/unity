using System.Collections;
using System.Collections.Generic;
using Best.HTTP.SecureProtocol.Org.BouncyCastle.Crypto.Generators;
using Newtonsoft.Json;
using UnityEngine;
using System;
using Edukit;
using UnityEngine.UIElements;

public class ControllMessage : MonoBehaviour
{
    public List<ControllData> ControllDataList;
    public event Action<string> onControllMessage;
    // Start is called before the first frame update
    void Start()
    {
        /*ControllDataList = new List<ControllData>();
        ControllDataList.Add(new ControllData { tagId ="1", name = "StartState", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="2", name = "StopState", value = "0" } );
        ControllDataList.Add(new ControllData { tagId ="3", name = "ResetState", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="4", name = "ColorSensorState", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="5", name = "VisionSensorState", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="6", name = "No1State", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="7", name = "No2State", value = "0" });
        ControllDataList.Add(new ControllData { tagId ="8", name = "No3State", value = "0" });
        */

        GameObject.Find("startState").GetComponent<StartButton>().onStartButtonChanged += GenerateData;
        GameObject.Find("stopState").GetComponent<StopButton>().onStopButtonChanged += GenerateData;
        GameObject.Find("resetState").GetComponent<ResetButton>().onResetButtonChanged += GenerateData;
        GameObject.Find("colorSensorState").GetComponent<ColorSensorButton>().onColorSensorButtonChanged += GenerateData;
        GameObject.Find("visionSensorState").GetComponent<VisionSensorButton>().onVisionSensorButtonChanged += GenerateData;
        GameObject.Find("no1State").GetComponent<No1Button>().onNo1ButtonChanged += GenerateData;
        GameObject.Find("no2State").GetComponent<No2Button>().onNo2ButtonChanged += GenerateData;
        GameObject.Find("no3State").GetComponent<No3Button>().onNo3ButtonChanged += GenerateData;
   
    }
    
    public void GenerateData(int tagId, string value)
    {
        string[] name = {"startState","stopState","resetState","colorSensorState","visionSensorState","no1State","no2State","no3State" };
        ControllData data = new ControllData { tagId = tagId.ToString(), name = name[tagId-1], value = value };
        SerializeMessage(data);
    }

    private void SerializeMessage(ControllData data)
    {
        string message = JsonConvert.SerializeObject(data);
       //Debug.Log(message);
        onControllMessage?.Invoke(message);
    }
}

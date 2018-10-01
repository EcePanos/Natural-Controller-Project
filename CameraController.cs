using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;

public class CameraController : MonoBehaviour {

    public GameObject player;
    //SerialPort stream = new SerialPort("COM3", 115200);
    private Vector3 offset;

    void Start()
    {
       // stream.Open();
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        //string value = stream.ReadLine();
       // string[] values = value.Split(',');
       // offset.y += Single.Parse(values[2], CultureInfo.InvariantCulture);
        transform.position = player.transform.position + offset;
    }
}


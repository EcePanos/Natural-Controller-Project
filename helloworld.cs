using UnityEngine;
using System;
//using System.Collections;
using System.IO.Ports;
//important Note! Unity must be set to .NET 2.0 compatibility!
public class helloworld : MonoBehaviour {
    SerialPort stream = new SerialPort("COM3", 9600);
    // Use this for initialization
    void Start () {
        stream.Open();
    }
	
	// Update is called once per frame
	void Update () {
        
        string value = stream.ReadLine();
        string[] values = value.Split(',');
        int val = Int32.Parse(values[2]);
        // print(values[0]+"and"+values[1]+"and"+values[2]);
        print(val);
    }
}

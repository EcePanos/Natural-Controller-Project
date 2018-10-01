using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;

public class Calibration : MonoBehaviour {
    SerialPort stream = new SerialPort("COM3", 115200);
    string value = "";

    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(this);
        stream.Open();
    }
	
	// Update is called once per frame
	void Update () {
        value = stream.ReadLine();

        string[] values = value.Split(',');

        float x = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
        float y = float.Parse(values[2], CultureInfo.InvariantCulture.NumberFormat);
        float z = float.Parse(values[0], CultureInfo.InvariantCulture.NumberFormat);

        float roundedz = Mathf.LerpAngle(transform.eulerAngles.z, -z, 5.0f * Time.deltaTime);
        float roundedy = Mathf.LerpAngle(transform.eulerAngles.y, -y, 5.0f * Time.deltaTime);
        float roundedx = Mathf.LerpAngle(transform.eulerAngles.x, x, 5.0f * Time.deltaTime);

        transform.eulerAngles = new Vector3(
                roundedx,
                roundedy,
                roundedz
            );
        if (Input.GetKey(KeyCode.F))
        {
            stream.Close();
            initialization.calibrationData.x = roundedx;
            initialization.calibrationData.y = roundedy;
            initialization.calibrationData.z = roundedz;
            Application.LoadLevel(1);
        }
    }
}

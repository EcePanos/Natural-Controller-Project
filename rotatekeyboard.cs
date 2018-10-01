using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;


public class rotatekeyboard : MonoBehaviour {
    //int speed=100;
    // Use this for initialization
    SerialPort stream = new SerialPort("COM3", 115200);
    public static int winCount = 0;
    public static int trialCount = 0;
    public static float roundedx = 0;
    public static float roundedy = 0;
    public static float roundedz = 0;
    string value = "";
    
    void Start () {
        stream.Open();
        
    }
	
	// Update is called once per frame
	void Update () {
        // stream.WriteLine("Ready");
       // if (stream.BytesToRead > 0)
        //{
            value = stream.ReadLine();
       // }
		string[] values = value.Split(',');
        float x = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
        float y = float.Parse(values[2], CultureInfo.InvariantCulture.NumberFormat);
        float z = float.Parse(values[0], CultureInfo.InvariantCulture.NumberFormat);
        /*
        x = Math.Round(x/5)*5;
        y = Math.Round(y/5)*5;
        z = Math.Round(z/5)*5;
        float roundedx = (float)x;
        float roundedy = (float)y;
        float roundedz = (float)z;
        */
        roundedz = Mathf.LerpAngle(transform.eulerAngles.z, -z, 5.0f * Time.deltaTime);
        roundedy = Mathf.LerpAngle(transform.eulerAngles.y, -y, 5.0f * Time.deltaTime);
        roundedx = Mathf.LerpAngle(transform.eulerAngles.x, x, 5.0f * Time.deltaTime);
        transform.eulerAngles = new Vector3(
                roundedx,
                roundedy,
                roundedz
            );
        //Console.WriteLine("{ 0},{ 1},{ 2}", roundedx.ToString(), (-roundedy).ToString(), roundedz.ToString());
        print("x="+roundedx+",y="+roundedy+",z="+roundedz+"Progress="+winCount);
        //-15,-85,-15 US location
        if (trialCount == 0)
        {
            if (transform.eulerAngles.x >= 345 && transform.eulerAngles.x <= 360 && transform.eulerAngles.y >= 65 && transform.eulerAngles.y <= 95 && transform.eulerAngles.z >= 315 && transform.eulerAngles.z <= 355)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 1)
        {
            if (transform.eulerAngles.x >= 20 && transform.eulerAngles.x <= 50 && transform.eulerAngles.y >= 190 && transform.eulerAngles.y <= 220 && transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 30)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 2)
        {
            if (transform.eulerAngles.x >= 15 && transform.eulerAngles.x <= 45 && transform.eulerAngles.y >= 180 && transform.eulerAngles.y <= 205 && transform.eulerAngles.z >= 5 && transform.eulerAngles.z <= 45)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 3)
        {
            if (transform.eulerAngles.x >= 20 && transform.eulerAngles.x <= 40 && transform.eulerAngles.y >= 180 && transform.eulerAngles.y <= 200 && transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 20)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 4)
        {
            if (transform.eulerAngles.x >= 20 && transform.eulerAngles.x <= 40 && transform.eulerAngles.y >= 190 && transform.eulerAngles.y <= 210 && transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 20)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 5)
        {
            if (transform.eulerAngles.x >= 35 && transform.eulerAngles.x <= 65 && transform.eulerAngles.y >= 165 && transform.eulerAngles.y <= 195 && transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 20)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 6)
        {
            if (transform.eulerAngles.x >= 325 && transform.eulerAngles.x <= 355 && transform.eulerAngles.y >= 100 && transform.eulerAngles.y <= 130 && transform.eulerAngles.z >= 5 && transform.eulerAngles.z <= 35)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 7)
        {
            if (transform.eulerAngles.x >= 30 && transform.eulerAngles.x <= 60 && transform.eulerAngles.y >= 205 && transform.eulerAngles.y <= 235 && transform.eulerAngles.z >= 20 && transform.eulerAngles.z <= 50)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 8)
        {
            if (transform.eulerAngles.x >= 15 && transform.eulerAngles.x <= 45 && transform.eulerAngles.y >= 295 && transform.eulerAngles.y <= 325 && transform.eulerAngles.z >= 330 && transform.eulerAngles.z <= 360)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                winCount = 0;
            }
        }
        if (trialCount == 9)
        {
            if (transform.eulerAngles.x >= 325 && transform.eulerAngles.x <= 355 && transform.eulerAngles.y >= 215 && transform.eulerAngles.y <= 245 && transform.eulerAngles.z >= 325 && transform.eulerAngles.z <= 355)
            {
                if (winCount < 100)
                {
                    winCount++;
                }
            }
            else if (winCount > 0)
            {
                winCount--;
            }
            if (winCount >= 100)
            {
                print("You Win!");
                trialCount++;
                //winCount = 0;
            }
        }

        //transform.Rotate(roundedx - transform.rotation.x, roundedy - transform.rotation.y, roundedz - transform.rotation.z);

    }
}

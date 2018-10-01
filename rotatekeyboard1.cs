using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;


public class rotatekeyboard1 : MonoBehaviour {
    int speed=100;
    // Use this for initialization
    
    public static int winCount = 0;
    public static int trialCount = 0;
    void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
        // stream.WriteLine("Ready");
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime,Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-Vector3.left * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime, Space.World);
        }



        //Console.WriteLine("{ 0},{ 1},{ 2}", roundedx.ToString(), (-roundedy).ToString(), roundedz.ToString());
        print("x="+ transform.eulerAngles.x + ",y="+ transform.eulerAngles.y + ",z="+transform.eulerAngles.z+"Progress="+winCount);
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;


public class rotatekeyboard2 : MonoBehaviour {
    int speed=100;
    // Use this for initialization
    
    public static int winCount = 0;
    public static int trialCount = 0;
    public static String displayedCountry = "";
    public static int slotCounter = 0;
    public static int mode = 0;
    public static int success = 0;
    public static int testSlotCounter = 0;
    int match = 0;
    String[] password = new String[10];
    String[] testPassword = new String[10];


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
        if (mode == 0)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                testPassword[slotCounter] = displayedCountry;
                slotCounter++;
                if (slotCounter > 9) mode = 1;

            }
        }
        else if (mode == 1)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                password[testSlotCounter] = displayedCountry;
                testSlotCounter++;
                if (testSlotCounter > 9) mode = 2;
                for (int i = 0; i < 10; i++)
                {
                    print(password[i] + testPassword[i]);
                    if (password[i] == testPassword[i]) match++;
                    print(match);
                }
                if (match == 10) success++;
            

        }
        }
        /*
        else if (mode == 2) {
            if (Input.GetKeyDown(KeyCode.F))
            {
                for (int i = 0; i < 10; i++)
                {
                    print(password[i] + testPassword[i]);
                    if (password[i] == testPassword[i]) match++;
                    print(match);
                }
                if (match == 10) success++;
            }
        }
        */
            //Console.WriteLine("{ 0},{ 1},{ 2}", roundedx.ToString(), (-roundedy).ToString(), roundedz.ToString());
            //print("x="+ transform.eulerAngles.x + ",y="+ transform.eulerAngles.y + ",z="+transform.eulerAngles.z+"Progress="+winCount);
        //-15,-85,-15 US location
        
        if (transform.eulerAngles.x >= 345 && transform.eulerAngles.x <= 360 && transform.eulerAngles.y >= 65 && transform.eulerAngles.y <= 95 && transform.eulerAngles.z >= 315 && transform.eulerAngles.z <= 355)
        {
        displayedCountry = "North America";
        }
           
        if (transform.eulerAngles.x >= 20 && transform.eulerAngles.x <= 50 && transform.eulerAngles.y >= 190 && transform.eulerAngles.y <= 220 && transform.eulerAngles.z >= 0 && transform.eulerAngles.z <= 30)
        {
        displayedCountry = "Europe";
        }
            
        if (transform.eulerAngles.x >= 325 && transform.eulerAngles.x <= 355 && transform.eulerAngles.y >= 100 && transform.eulerAngles.y <= 130 && transform.eulerAngles.z >= 5 && transform.eulerAngles.z <= 35)
        {
        displayedCountry = "South America";
        }
                  
        if (transform.eulerAngles.x >= 15 && transform.eulerAngles.x <= 45 && transform.eulerAngles.y >= 295 && transform.eulerAngles.y <= 325 && transform.eulerAngles.z >= 330 && transform.eulerAngles.z <= 360)
        {
            displayedCountry = "Australia"; 
        }
            
       
        //transform.Rotate(roundedx - transform.rotation.x, roundedy - transform.rotation.y, roundedz - transform.rotation.z);

    }
}

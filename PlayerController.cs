using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
//using System.Collections;
using System.IO.Ports;
using System.Globalization;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    SerialPort stream = new SerialPort("COM3",115200);
    void Start()
    {
        stream.Open();
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        string value = stream.ReadLine();
        string[] values = value.Split(',');
        

        Vector3 movement = new Vector3(Single.Parse(values[0], CultureInfo.InvariantCulture) /100, Single.Parse(values[2], CultureInfo.InvariantCulture)/1000, Single.Parse(values[1], CultureInfo.InvariantCulture) /100);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 13)
        {
            winText.text = "You Win!";
        }
    }
}

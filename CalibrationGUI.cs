using UnityEngine;
using System.Collections;

public class CalibrationGUI : MonoBehaviour
{

    // Use this for initialization
    private void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 100, 400, 70), "Please place your device on a level sufrace \n with the cord facing away from the screen and  \n press the F key");
    }
}

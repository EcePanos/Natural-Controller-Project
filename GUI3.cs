using UnityEngine;
using System.Collections;

public class GUI3 : MonoBehaviour {
    int score = 10000;
    void OnGUI()
    {
       GUI.Box(new Rect((Screen.width/2 - Screen.width/8 ), (Screen.height/2-Screen.height/6), Screen.width/4, Screen.height/2), "");
       
       GUI.Box(new Rect(10, 10, 220, 170), "Current region: " + rotatekeyboard2.displayedCountry);


        //GUI.Box(new Rect(20, 40, 120, 30), "Certainty: " + rotatekeyboard2.winCount + "%");
        //GUI.Box(new Rect(20, 80, 120, 30), "Score: " +score);
        if (rotatekeyboard2.mode == 0)
        {
            GUI.Box(new Rect(20, 120, 120, 30), "Slot: " + ((rotatekeyboard2.slotCounter) + 1) + " out of 10");
        }
        if (rotatekeyboard2.mode == 1)
        {
            GUI.Box(new Rect(20, 120, 120, 30), "Slot: " + ((rotatekeyboard2.testSlotCounter) + 1) + " out of 10");
        }
        if (rotatekeyboard2.mode == 2)
        {
            GUI.Box(new Rect(20, 120, 120, 30), "Success: " + (rotatekeyboard2.success));
        }
    }
}

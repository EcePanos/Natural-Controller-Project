using UnityEngine;
using System.Collections;

public class GUI2 : MonoBehaviour {
    int score = 10000;
    void OnGUI()
    {
       // GUI.Box(new Rect((Screen.width - 400) / 2, (Screen.height-200) / 2, 400, 400), "");
        if (rotatekeyboard1.trialCount == 0)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find The USA!");
        }
        if (rotatekeyboard1.trialCount == 1)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Europe!");
        }
        if (rotatekeyboard1.trialCount == 2)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Spain!");
        }
        if (rotatekeyboard1.trialCount == 3)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Italy!");
        }
        if (rotatekeyboard1.trialCount == 4)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Greece!");
        }
        if (rotatekeyboard1.trialCount == 5)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find the UK!");
        }
        if (rotatekeyboard1.trialCount == 6)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find South America!");
        }
        if (rotatekeyboard1.trialCount == 7)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Scandinavia!");
        }
        if (rotatekeyboard1.trialCount == 8)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Australia!");
        }
        if (rotatekeyboard1.trialCount == 9)
        {
            GUI.Box(new Rect(10, 10, 140, 170), "Find Madagascar!");
        }
        GUI.Box(new Rect(20, 40, 120, 30), "Certainty: " + rotatekeyboard1.winCount + "%");
        GUI.Box(new Rect(20, 80, 120, 30), "Score: " +score);
        GUI.Box(new Rect(20, 120, 120, 30), "Trial: " + ((rotatekeyboard1.trialCount)+1) + " out of 10");
        if (rotatekeyboard1.trialCount >= 10)
        {
            GUI.Box(new Rect(800, 400, 100, 20), "You win!");
        }
        else
        {
            if (score > 0)
            {
                score--;
            }
        }
        if (score <= 0)
        {
            GUI.Box(new Rect(800, 400, 100, 20), "Game Over");
        }
    }
}

using UnityEngine;
using System.Collections;

public class rotatecoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3(
               rotatekeyboard.roundedx,
               rotatekeyboard.roundedy,
               rotatekeyboard.roundedz
           );
    }
}

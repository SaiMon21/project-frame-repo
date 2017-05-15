using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeScreenshot : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P)) {
			createScreenshot ();
		}
	}

	public void createScreenshot(){
		Application.CaptureScreenshot("P3_scrn_.png",3);
		Debug.Log ("Screenshot successfully saved to main project folder");
	}
}

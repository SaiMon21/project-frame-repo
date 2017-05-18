using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorTriggerManager : MonoBehaviour {

	public bool activeSetA;
	public GameObject[] objectSetA;
	public GameObject[] objectSetB;


	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			activateTriggerObjects ();
		}

	}
		
	void OnTriggerExit(Collider player){
		deactivateTriggerObjects ();
	}



	// Fully axtivate an object
	public void activateTriggerObjects(){
		activeSetA = true;
		foreach (GameObject objects in objectSetA) {
			objects.SetActive (true);
			Debug.Log ("Objects in array are now ACTIVATED");
		}

		foreach (GameObject objects in objectSetB) {
			objects.SetActive (false);
		}
	}


	// Fully 
	public void deactivateTriggerObjects(){
		activeSetA = false;
		foreach (GameObject objects in objectSetA) {
			objects.SetActive (false);
			Debug.Log ("Objects in array are now INACTIVE");
		}

		foreach (GameObject objects in objectSetB) {
			objects.SetActive (true);
		}
	}








}

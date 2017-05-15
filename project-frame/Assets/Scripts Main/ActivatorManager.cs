using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorManager : MonoBehaviour {

	public GameObject[] objToActivate;
	public GameObject[] objToDeactivate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Fully axtivate an object
	public void activateObjects(){
		foreach (GameObject objects in objToActivate) {
			objects.SetActive (true);
			Debug.Log ("Objects in array are now ACTIVATED");
		}
	}


	// Fully 
	public void deactivateObjects(){
		foreach (GameObject objects in objToDeactivate) {
			objects.SetActive (false);
			Debug.Log ("Objects in array are now DE-ACTIVATED");
		}
	}








}

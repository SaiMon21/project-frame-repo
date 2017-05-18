using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BridgeTrigger : MonoBehaviour {

	public bool playerInRange;
	public bool triggerOn;
	public DOTweenAnimation bridgeTweenAnim;
	public GameObject buttonPrompt;
	public Animator bridgeCubeAnim;

	// Use this for initialization
	void Start () {
		triggerOn = false;
		buttonPrompt.gameObject.SetActive (false);
		pauseTween();
	}
	
	// Update is called once per frame
	void Update () {

		if (playerInRange && Input.GetKeyDown(KeyCode.F)) {
			triggerOn = true;
			playTween ();
			buttonPrompt.gameObject.SetActive (false);
			bridgeCubeAnim.Play ("BridgeCubeMove");
		}
			
		if (triggerOn) {
			//playTween ();
		}

		if(!playerInRange) {
			//pauseTween ();
		}
			

	}


	void OnTriggerEnter(Collider playerObject){
		if (playerObject.tag == "BodyTrigger") {
			playerInRange = true;

			//triggerOn = true;
			Debug.Log ("Player within Bridge trigger range.");
			if (!triggerOn) {
				buttonPrompt.gameObject.SetActive (true);
			}
		}
	}
		
	void OnTriggerExit(Collider other){
		playerInRange = false;
		buttonPrompt.gameObject.SetActive (false);
		Debug.Log ("Player NOT within range.");
	}
		

	// Pause all tweens
	public void pauseTween(){
		DOTween.Pause ("dtBridge");
	}

	public void playTween(){
		DOTween.Play ("dtBridge");
		Debug.Log ("PLAY bridge rotation tween.");
	}

	public void destroyBridge(){
		Destroy (gameObject);
	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BridgeTrigger : MonoBehaviour {

	public bool playerInRange;
	public bool triggerOn;
	public DOTweenAnimation bridgeTweenAnim;
	public Image buttonPrompt;
	public Animator bridgeCubeAnim;
	public GameObject mediaPlayer;
	public Material area1Skybox;
	public float fadeDuration;

	// Use this for initialization
	void Start () {
		triggerOn = false;
		//buttonPrompt.gameObject.SetActive (false);
		mediaPlayer.gameObject.SetActive (false);
		area1Skybox.DOFade (1f, 0.1f);
		pauseTween();
	}

	// Update is called once per frame
	void Update () {

		if (playerInRange && Input.GetKeyDown(KeyCode.F)) {
			triggerOn = true;
			playTween ();
			mediaPlayer.gameObject.SetActive (true);
			buttonPrompt.DOFade (0, 0.4f);
			bridgeCubeAnim.Play ("BridgeCubeMove");
			area1Skybox.DOFade (0f, fadeDuration);


		}
			
		if (playerInRange && !triggerOn) {
			//playTween ();
			buttonPrompt.DOFade (1, 0.4f);
		}

		if(!playerInRange ||triggerOn == true) {
			//pauseTween ();

		}
			

	}


	void OnTriggerEnter(Collider playerObject){
		if (playerObject.tag == "BodyTrigger") {
			playerInRange = true;



			//triggerOn = true;
			Debug.Log ("Player within Bridge trigger range.");
			if (!triggerOn) {
				//buttonPrompt.gameObject.SetActive (true);
			}
		}
	}
		
	void OnTriggerExit(Collider other){
		playerInRange = false;
		//buttonPrompt.gameObject.SetActive (false);
		buttonPrompt.DOFade (0, 0.4f);
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
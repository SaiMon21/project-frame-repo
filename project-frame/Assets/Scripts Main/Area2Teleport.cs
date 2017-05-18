using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Area2Teleport : MonoBehaviour {

	// SCRIPT USAGE:
	// 1. Place this script on a trigger object.
	// 2. When triggered, the script will activate a fade-in animation.
	// 3. Followed by the removal of all Area #1 objects.
	// 4. The Player will be teleported to the Area #2 Teleport object's transform position

	public GameObject playerObject; // The Player object
	public GameObject teleportObject; // The Empty Object for teleporting the player
	public GameObject mainCamera; // Main Camera, for re-activating it.
	public GameObject cameraC; // Previous camera (Camera-C). Needs to be removed during teleportation.
	public DOTweenAnimation blackScreenFade; // The object with its own DoTween Fade animations
	public Image blackScreen;
	public bool timeSwitch;
	public float timeToTeleport;
	public float fadeDuration;



	//public GameObject area1Manager; // The Empty Object holding all Area #1 objects


	void Start(){
		//pauseTween();
		timeSwitch = false;
	}

	void OnTriggerEnter(Collider player){
		if (player.tag == "Player") {
			//playArea2FadeIn ();
			Debug.Log ("Tween set to 'Play'");
			playFadeSequence();
			timeSwitch = true;

			//playArea2FadeOut ();
			//playArea2FadeIn ();
			//Debug.Log ("Player has teleorted to Area #2");
		}
	}



	void Update(){
		if (timeSwitch) {
			timeToTeleport += Time.deltaTime;
		}

		if (timeToTeleport >= fadeDuration) {
			optimizeLevel ();
		}
	}



//	public void pauseTween(){
//		DOTween.Pause ("ScreenFadeIn");
//		DOTween.Pause ("ScreenFadeOut");
//	}


//	public void playArea2FadeIn(){
//		DOTween.Play ("ScreenFadeIn");
//		//DOTween.Play ("ScreenFadeIn");
//		//blackScreen.DOFade (0f, 4f);
//		Debug.Log ("Area #2 - Scene Fade In.");
//		//yield return new WaitForSeconds (1f);
//
//	}


//	public void playArea2FadeOut(){
//		DOTween.Play ("ScreenFadOut");
//
//		//blackScreen.DOFade (0f, 4f);
//		//DOTween.Play ("ScreenFadeOut");
//		Debug.Log ("Area #2 - Scene Fade Out");
//	}
//


	public void optimizeLevel(){
		playerObject.transform.position = teleportObject.transform.position;
		mainCamera.SetActive (true);
		cameraC.SetActive (false);
		Destroy (gameObject);
	}


	public void playFadeSequence(){
		Sequence fadeSequence = DOTween.Sequence ();
		fadeSequence.Append (blackScreen.DOFade (1f, fadeDuration));
		fadeSequence.Append (blackScreen.DOFade (0f, fadeDuration));

	}





}

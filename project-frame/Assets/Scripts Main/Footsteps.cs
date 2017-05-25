using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

	//CharacterController cc;
	public AudioSource playerAudioSource;
	//public AudioClip[] footstepSFX;
	//public float volumeScale;
	//public float pitchHighRange; // Pitch High Range
	//public float pitchLowRange; // Pitch Default Value


	void Start(){
		//cc = GetComponent<CharacterController> ();
	}


	void Update(){
//		if (cc.isGrounded == true && cc.velocity.magnitude > 2f && playerAudioSource.isPlaying == false) {
//			playerAudioSource.volume = Random.Range (0.8f, 1f);
//			playerAudioSource.pitch = Random.Range (1f, 1.1f);
//			playerAudioSource.Play ();
//		}
	}

//	public void playFootsteps(){
//
//		playerAudioSource.pitch = Random.Range (pitchLowRange, pitchHighRange);
//		playerAudioSource.PlayOneShot (footstepSFX [0], volumeScale);
//
//	}




	public void playFootstep(){
		playerAudioSource.volume = Random.Range (0.8f, 1f);
		playerAudioSource.pitch = Random.Range (1f, 1.1f);
		playerAudioSource.Play ();
	}





}

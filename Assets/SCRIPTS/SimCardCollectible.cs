using UnityEngine;
using System.Collections;

public class SimCardCollectible : MonoBehaviour {

	public AudioClip pickUpSound;

	void Start() {

	}

	void PlayPickUpSound() {
		if (pickUpSound) {
			AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
		}
	}

	void Update() {

	}

	void OnTriggerEnter2D(Collider2D target) {
		if(target.gameObject.tag == "Dino") {
			PlayPickUpSound();
			Destroy(gameObject);
		}

	}
}

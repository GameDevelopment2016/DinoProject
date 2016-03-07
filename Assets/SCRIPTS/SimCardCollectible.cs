using UnityEngine;
using System.Collections;

public class SimCardCollectible : MonoBehaviour {

	public float simCardMoveRate = 1f;
	public AudioClip pickUpSound;

	void Start() {

	}

	void PlayPickUpSound() {
		if (pickUpSound) {
			AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
		}
	}

	void Update() {
		transform.position = new Vector2(transform.position.x - simCardMoveRate, transform.position.y);
	}

	void OnTriggerEnter2D(Collider2D target) {
		if(target.gameObject.tag == "Dino") {
			PlayPickUpSound();
			Destroy(target.gameObject);
			Application.LoadLevel("Level2");
		}

	}
}

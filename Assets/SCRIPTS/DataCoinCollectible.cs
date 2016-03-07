using UnityEngine;
using System.Collections;

public class DataCoinCollectible : MonoBehaviour {

	public AudioClip pickUpSound;
	public float dataCoinMoveRate = 1;

	public LevelAttributes lvlAttributes;

	void Start() {

	}

	void PlayPickUpSound() {
		if (pickUpSound) {
			AudioSource.PlayClipAtPoint(pickUpSound, transform.position);
		}
	}

	void Update() {

	}

	void FixedUpdate() {
		transform.position = new Vector2(transform.position.x - dataCoinMoveRate, transform.position.y);

		if (transform.position.x <= -31f) {
			transform.position = new Vector2(31f, transform.position.y);
		}
	}

	void OnTriggerEnter2D(Collider2D target) {
		if(target.gameObject.tag == "Dino") {
			PlayPickUpSound();
			lvlAttributes.DataCoinsCollect();
			Destroy(gameObject);
		}

	}
}

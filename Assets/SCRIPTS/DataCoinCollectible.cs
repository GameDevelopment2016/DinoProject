using UnityEngine;
using System.Collections;

public class DataCoinCollectible : MonoBehaviour {

	public AudioClip pickUpSound;
	public float dataCoinMoveRate = 1;

	public Level1Attributes lvlAttributes;
	private Animator animator;

	private bool collected;

	void Start() {
		animator = GetComponent<Animator>();
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

		if ((transform.position.x <= -20f && lvlAttributes.dataCoinsSpawned < lvlAttributes.dataCoinsSpawnedMax - 2) || collected) {
			lvlAttributes.DataCoinsSpawn();
			collected = false;
			animator.SetInteger("CoinState", 0);
			transform.position = new Vector2(Random.Range(20, 25), transform.position.y);
		}
	}

	void OnTriggerEnter2D(Collider2D target) {
		if(target.gameObject.tag == "Dino") {
			PlayPickUpSound();
			lvlAttributes.DataCoinsCollect();
			collected = true;
			animator.SetInteger("CoinState", 1);
		}

	}
}

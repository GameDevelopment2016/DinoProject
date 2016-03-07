using UnityEngine;
using System.Collections;

public class BigCactusController : MonoBehaviour {

	public Sprite[] sprites;
	public string resourceName;
	public int currentSprite = -1;

	public float bigCactusMoveRate;

	void Start() {
		if(resourceName != "") {
			sprites = Resources.LoadAll<Sprite>(resourceName);

			if(currentSprite == -1) {
				currentSprite = Random.Range(0, sprites.Length);
			} else if(currentSprite > sprites.Length) {
				currentSprite = sprites.Length - 1;
			}
			GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
		}
	}

	void Update() {
	
	}

	void FixedUpdate() {
		transform.position = new Vector2(transform.position.x - bigCactusMoveRate, transform.position.y);

		if (transform.position.x <= -31f) {
			transform.position = new Vector2(Random.Range(30, 35), transform.position.y);
		}
	}
}

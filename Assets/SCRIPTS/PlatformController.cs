using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	public float backGroundMoveRate = .07f;

	void Start() {
	
	}

	void Update() {
	
	}

	void FixedUpdate() {
		transform.position = new Vector2(transform.position.x - backGroundMoveRate, transform.position.y);

		if (transform.position.x <= -31f) {
			transform.position = new Vector2(31f, transform.position.y);
		}
	}
}

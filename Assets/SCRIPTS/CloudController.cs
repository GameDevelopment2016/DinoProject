using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {

	public float cloudMoveRate = 1;

	void Start() {

	}

	void Update() {

	}

	void FixedUpdate() {
		transform.position = new Vector2(transform.position.x - cloudMoveRate, transform.position.y);

		if (transform.position.x <= -15f) {
			transform.position = new Vector2(Random.Range(20, 30), transform.position.y);
		}
	}
}

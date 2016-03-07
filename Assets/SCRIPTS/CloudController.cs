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

		if (transform.position.x <= -31f) {
			transform.position = new Vector2(31f, transform.position.y);
		}
	}
}

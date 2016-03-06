using UnityEngine;
using System.Collections;

public class DinoController : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(3, 5);
	public bool standing;
	public float jetSpeed = 15f;
	public float airSpeedMultiplier = .3f;
	public float jumpHeight = 15f;

	public Vector2 moving = new Vector2();

	private Animator animator;

	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {
		moving.x = moving.y = 0;

		var forceX = 0f;
		var forceY = 0f;

		var absValX = Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x);
		var absValY = Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y);

		if(absValY <.2f) {
			standing = true;
		}else{
			standing = false;
		}

		if(Input.GetKey("right")) {
			moving.x = 1;
		} else if(Input.GetKey("left")) {
			moving.x = -1;
		}
		
		if(Input.GetKey("up")) {
			moving.y = 1;
		} else if(Input.GetKey("down")) {
			moving.y = -1;
		}

		if (moving.x != 0) {
			if (absValX < maxVelocity.x) {
				forceX = standing ? speed * moving.x : (speed * moving.x * airSpeedMultiplier);
				transform.localScale = new Vector3(forceX > 0 ? 1 : -1, 1, 1);
			}
			animator.SetInteger("AnimState", 1);
		} else {
			animator.SetInteger("AnimState", 0);
		}

		if (moving.y > 0) {
			if (absValY < maxVelocity.y) {
				forceY = jetSpeed * moving.y;
			}
		}

		GetComponent<Rigidbody2D>().AddForce(new Vector2(forceX, forceY));
	}
}

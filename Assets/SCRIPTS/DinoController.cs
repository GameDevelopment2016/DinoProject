using UnityEngine;
using System.Collections;

public class DinoController : MonoBehaviour {
	
	public bool standing;
	public float jumpHeight = 15f;
	public float acceleration = 0.1f;

	private Animator animator;

	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {

		var absValY = Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y);

		if(absValY < .2f) {
			standing = true;
		}else{
			standing = false;
		}
			
		if(Input.GetKey("up")) {
			if (standing) {
				animator.SetInteger ("AnimState", 1);
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
			} else {
				animator.SetInteger ("AnimState", 0);
			}
		}
	}
}

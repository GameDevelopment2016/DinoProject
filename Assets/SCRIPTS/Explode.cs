using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	void Start() {

	}
		
	void Update() {

	}

	void OnTriggerEnter2D(Collider2D target) {
		if(target.gameObject.tag == "Deadly") {
			OnExplode();
		}
	}

	void OnCollisionEnter2D(Collision2D target) {
		if(target.gameObject.tag == "Deadly") {
			OnExplode();
		}
	}

	public void OnExplode(){
		Destroy(gameObject);
	}
}

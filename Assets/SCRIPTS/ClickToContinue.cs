using UnityEngine;
using System.Collections;

public class ClickToContinue : MonoBehaviour {

	public string scene;
	public bool loadLock;

	void Start() {
	
	}

	void Update() {
		if (Input.GetMouseButtonDown(0) && !loadLock) {
			LoadScene();
		}
	}

	void LoadScene() {
		loadLock = true;
		Application.LoadLevel(scene);
	}
}

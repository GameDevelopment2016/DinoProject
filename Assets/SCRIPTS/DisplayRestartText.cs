using UnityEngine;
using System.Collections;

public class DisplayRestartText : MonoBehaviour {

	public Texture2D texture;

	void Start() {
		texture = Resources.Load<Texture2D> ("Replay");
	}

	void Update() {
	
	}

	void OnGUI() {
		var x = 0;
		var y = 0;

		if (Time.time % 2 > 1) {
			GUI.DrawTexture (new Rect(x, y, texture.width / 4, texture.height / 4), texture);
		}
	}
}

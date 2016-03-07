using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataCoins10Manager : MonoBehaviour {

	public Text dataCoinsText;
	public Level1Attributes lvlAttributes;

	void Start () {
		dataCoinsText =  GetComponent<Text>();
	}

	void Update () {
		dataCoinsText.text = "" + lvlAttributes.GetDataCoinsCollected();
	}
}

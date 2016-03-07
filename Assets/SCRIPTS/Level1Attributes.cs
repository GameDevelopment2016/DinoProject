using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level1Attributes : MonoBehaviour {

	public int dataCoinsSpawned;
	public int dataCoinsCollected = 0;
	public int dataCoinsSpawnedMax = 10;

	public Transform simCard;

	void Start () {

	}

	void Update () {
		if(dataCoinsSpawned == dataCoinsSpawnedMax) {
			Instantiate (simCard, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
		}
	}

	public void DataCoinsCollect() {
		if(dataCoinsCollected < dataCoinsSpawnedMax) {
			dataCoinsCollected++;
		}
	}

	public void DataCoinsSpawn() {
		dataCoinsSpawned++;
	}

	public int GetDataCoinsSpawned() {
		return dataCoinsSpawned;
	}

	public int GetDataCoinsCollected() {
		return dataCoinsCollected;
	}
}

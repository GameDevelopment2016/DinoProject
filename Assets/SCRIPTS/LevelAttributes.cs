using UnityEngine;
using System.Collections;

public class LevelAttributes : MonoBehaviour {

	private int dataCoinsSpawned;
	public int dataCoinsCollected = 0;
	public int dataCoinsSpawnedMax = 20;

	void Start () {
	
	}

	void Update () {
	
	}

	public void DataCoinsCollect() {
		if(dataCoinsCollected < dataCoinsSpawnedMax) {
			dataCoinsCollected++;
		}
	}

	public void DataCoinsSpawn() {
		dataCoinsSpawned++;
	}
}

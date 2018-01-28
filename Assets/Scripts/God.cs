using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

	public int NumberOfMountains = 100;
	public GameObject MountainPrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < NumberOfMountains; i++) {
			Vector3 mountPos = new Vector3(Random.Range(-200,200), Random.Range(2f,15f), Random.Range(100, 1000));
			GameObject newMountain = Instantiate(MountainPrefab, mountPos, transform.rotation);
			float mountScale = Random.Range(0.5f,5f);
			newMountain.transform.localScale = new Vector3 (mountScale, mountScale, mountScale);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

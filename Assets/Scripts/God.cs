using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour {

	public int NumberOfMountains = 100;
	public GameObject MountainPrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < NumberOfMountains; i++) {
			Vector3 mountPos = new Vector3(Random.Range(-100,100), Random.Range(5f,20f), Random.Range(100, 1000));
			GameObject newMountain = Instantiate(MountainPrefab, mountPos, transform.rotation);
			float mountScale = 1;//Random.Range(0.5f,5f);
			newMountain.transform.localScale = new Vector3 (mountScale, mountScale, mountScale);
		}
		StartCoroutine(SpawnTheFuckers());
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}

	IEnumerator SpawnTheFuckers() {
		while(true){
			Vector3 mountPos = new Vector3(Random.Range(GameManager.Instance.ThePlayer.transform.position.x -100,GameManager.Instance.ThePlayer.transform.position.x + 100), Random.Range(5f,20f), Random.Range(100, 1000));
			GameObject newMountain = Instantiate(MountainPrefab, mountPos, transform.rotation);
			float mountScale = 1;//Random.Range(0.5f,5f);
			newMountain.transform.localScale = new Vector3 (mountScale, mountScale, mountScale);
			yield return new WaitForSeconds(Random.Range(0.1f,0.5f));
		}
	}

}

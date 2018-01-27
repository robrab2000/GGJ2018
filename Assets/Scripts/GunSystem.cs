using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour {

	public float BulletSpeed, FireRate;
	public GameObject BulletPrefab, GunL, GunR;

	private Transform gunL, gunR;

	// Use this for initialization
	void Start () {
		gunL = GunL.transform;
		gunR = GunR.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shoot() {
		GameObject bullet1 = Instantiate(BulletPrefab, gunL.position, gunL.rotation);
		GameObject bullet2 = Instantiate(BulletPrefab, gunR.position, gunR.rotation);

		bullet1.GetComponent<Rigidbody>().AddForce(gunL.up * BulletSpeed, ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(gunR.up * BulletSpeed, ForceMode.Impulse);
	}
}

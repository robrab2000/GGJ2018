using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour {

	public float BulletSpeed, FireRate;
	public GameObject BulletPrefab, GunL, GunR, Reticle;

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

		gunL.LookAt(Reticle.transform);
		gunR.LookAt(Reticle.transform);

		GameObject bullet1 = Instantiate(BulletPrefab, gunL.position, gunL.rotation * Quaternion.Euler(90,0,0));
		GameObject bullet2 = Instantiate(BulletPrefab, gunR.position, gunR.rotation * Quaternion.Euler(90,0,0));

		bullet1.GetComponent<Rigidbody>().AddForce(gunL.forward * BulletSpeed, ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(gunR.forward * BulletSpeed, ForceMode.Impulse);
	}
}

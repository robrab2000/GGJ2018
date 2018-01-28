using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour {

	public float BulletSpeed, FireRate;
	public GameObject BulletPrefab, GunL, GunR, Reticle;
	public AudioClip ShootSound;
	AudioSource audio;

	private Transform gunL, gunR;

	// Use this for initialization
	void Start () {
		gunL = GunL.transform;
		gunR = GunR.transform;
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShootStart() {
		InvokeRepeating("FireBullet", 0, FireRate);
	}

	public void ShootEnd() {
		CancelInvoke();
	}

	void FireBullet() {
		audio.PlayOneShot(ShootSound);

		gunL.LookAt(Reticle.transform);
		gunR.LookAt(Reticle.transform);

		GameObject bullet1 = Instantiate(BulletPrefab, gunL.position, gunL.rotation * Quaternion.Euler(90,0,0));
		GameObject bullet2 = Instantiate(BulletPrefab, gunR.position, gunR.rotation * Quaternion.Euler(90,0,0));

		bullet1.GetComponent<Rigidbody>().AddForce(gunL.forward * BulletSpeed, ForceMode.Impulse);
		bullet2.GetComponent<Rigidbody>().AddForce(gunR.forward * BulletSpeed, ForceMode.Impulse);
	}
}

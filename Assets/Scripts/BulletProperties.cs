using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroyBullet", 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyBullet() {
		Destroy(this.gameObject);
	}
}

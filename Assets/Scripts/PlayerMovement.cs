using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Transform bikeTrans;

	// Use this for initialization
	void Awake(){
		bikeTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		BikeRotation();
	}

	void BikeRotation() {
		Quaternion rotation = Quaternion.Euler(0, 0, GameInput.Instance.horizontalAxis1 * -15);
		bikeTrans.rotation = rotation;
	}
}

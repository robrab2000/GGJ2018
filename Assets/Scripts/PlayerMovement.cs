using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Transform bikeTrans;
	public float LerpSpeed;

	// Use this for initialization
	void Awake(){
		bikeTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		BikeRotation();
	}

	void BikeRotation() {
		Quaternion rotation = Quaternion.Euler(GameInput.Instance.verticalAxis2 * 5, GameInput.Instance.horizontalAxis1 * -5, GameInput.Instance.horizontalAxis1 * -15);
		bikeTrans.rotation = Quaternion.Lerp(bikeTrans.rotation, rotation, Time.time * LerpSpeed);
	}
}

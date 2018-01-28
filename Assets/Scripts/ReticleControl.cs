using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleControl : MonoBehaviour {

	Transform myTrans;

	// Use this for initialization
	void Start () {
		myTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		MoveReticle();
	}

	void MoveReticle() {
		myTrans.localPosition = new Vector3(GameInput.Instance.horizontalAxis2 * 5, GameInput.Instance.verticalAxis2 * -5, 40f);
	}
}

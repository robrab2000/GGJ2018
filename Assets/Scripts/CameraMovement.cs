using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	Transform camTrans;

	// Use this for initialization
	void Start () {
		camTrans = this.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		float push;
		if(camTrans.position.y < 2f) {
			push = Mathf.Clamp(GameInput.Instance.verticalAxis2, -1f,0f);
		}
		else if(camTrans.position.y > 20) {
			push = Mathf.Clamp(GameInput.Instance.verticalAxis2, 0f, 1f);
		}
		else {
			push = GameInput.Instance.verticalAxis2;
		}
		camTrans.Translate(new Vector3(0, push * -0.35f, 0));
		
	}
}

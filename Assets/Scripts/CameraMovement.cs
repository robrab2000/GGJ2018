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
		camTrans.Translate(new Vector3(GameInput.Instance.horizontalAxis, 0, 0));
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainMover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-GameManager.Instance.FlowRate.x,0,-GameManager.Instance.FlowRate.y);
	}


}

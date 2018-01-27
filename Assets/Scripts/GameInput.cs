using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class GameInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var inputDevice = InputManager.ActiveDevice;
        GameManager.Instance.FlowRate = inputDevice.RightTrigger.Value;
	}
}

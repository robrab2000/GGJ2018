using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class RollingGrid : MonoBehaviour {

public float throttle;

	[Range(0,1)]
	public float scrollSpeed = 0.5F;
    public Renderer rend;
    void Start() {
        rend = GetComponent<Renderer>();
        throttle = Input.GetAxis ("Throttle");
    }
    void Update() {

			// Use last device which provided input.
			var inputDevice = InputManager.ActiveDevice;
            print(inputDevice.RightTrigger.Value);

        float offset = rend.material.mainTextureOffset.y + Time.deltaTime * Utils.ofMap(inputDevice.RightTrigger.Value, -1f, 1f, 0.001f, 0.5f);
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}

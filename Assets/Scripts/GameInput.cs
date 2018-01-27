using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class GameInput : MonoBehaviour {

#region Singleton Check
	private static GameInput gameInputInstance = null;

	public static GameInput Instance {
		get { return gameInputInstance; }
	}


    void Awake ()
	{
		if (gameInputInstance != null && gameInputInstance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			gameInputInstance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
#endregion

public float horizontalAxis1, verticalAxis1, horizontalAxis2, verticalAxis2;
private GunSystem gunSystem;

	// Use this for initialization
	void Start () {
		gunSystem = GameManager.Instance.ThePlayer.GetComponent<GunSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		var inputDevice = InputManager.ActiveDevice;
        GameManager.Instance.FlowRate = inputDevice.RightTrigger.Value;
		horizontalAxis1 = inputDevice.LeftStick.X;
		verticalAxis1 = inputDevice.LeftStick.Y;

		horizontalAxis2 = inputDevice.RightStick.X;
		verticalAxis2 = inputDevice.RightStick.Y;

		if(inputDevice.RightBumper) {
			gunSystem.Shoot();
		}
	}
}

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

public float horizontalAxis, verticalAxis;
private GunSystem gunSystem;

	// Use this for initialization
	void Start () {
		gunSystem = GameManager.Instance.ThePlayer.GetComponent<GunSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		var inputDevice = InputManager.ActiveDevice;
        GameManager.Instance.FlowRate = inputDevice.RightTrigger.Value;
		horizontalAxis = inputDevice.LeftStick.X;
		verticalAxis = inputDevice.LeftStick.Y;

		if(inputDevice.RightBumper) {
			gunSystem.Shoot();
		}
	}
}

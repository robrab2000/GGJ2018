using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

#region Singleton Check
	private static GameManager gameManagerInstance = null;

	public static GameManager Instance {
		get { return gameManagerInstance; }
	}


    void Awake ()
	{
		if (gameManagerInstance != null && gameManagerInstance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			gameManagerInstance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
#endregion

	public float FlowRate;
	public GameObject ThePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FlowThrust(float newFlow) {
		FlowRate = newFlow;
	}
}

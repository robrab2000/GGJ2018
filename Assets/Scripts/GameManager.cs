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

	public Vector2 FlowRate;
	public GameObject ThePlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FlowThrust(float newFlowX, float newFlowY) {
		FlowRate = new Vector2(newFlowX, newFlowY);
	}
}

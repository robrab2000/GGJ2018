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

	public bool GameStarted = false;

	// Use this for initialization
	void Start () {
		Invoke("StartGame", 7f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FlowThrust(float newFlowX, float newFlowY) {
		FlowRate = new Vector2(newFlowX, newFlowY);
	}

	void StartGame() {
		GameStarted = true;
	}
}

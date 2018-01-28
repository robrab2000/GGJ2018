using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	public Text ScoreText;
	public int Score = 0;
	CursorLockMode lockMode;

	public bool GameStarted = false;

	// Use this for initialization
	void Start () {
		Invoke("StartGame", 7f);
		lockMode = CursorLockMode.Locked;
		Cursor.visible = (CursorLockMode.Locked != lockMode);

	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = Score.ToString();
		if(Input.GetKeyDown(KeyCode.Escape) ){
			print ("Quit");
			Application.Quit();
		}
	}

	public void FlowThrust(float newFlowX, float newFlowY) {
		FlowRate = new Vector2(newFlowX, newFlowY);
	}

	void StartGame() {
		GameStarted = true;
	}
}

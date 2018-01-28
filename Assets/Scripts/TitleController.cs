using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleController : MonoBehaviour {

	public Text Midnight, Turbo;
	public float MidnightFadeRate, TurboFadeRate, FleeSpeed;
	public Color midnightEmpty, midnightFull;
	public Color turboEmpty, turboFull;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameManager.Instance.GameStarted) {
		Midnight.color = Color.Lerp(midnightEmpty, midnightFull, Time.time * MidnightFadeRate);
		Turbo.color = Color.Lerp(turboEmpty, turboFull, Time.time * TurboFadeRate);

		}
		else if (GameManager.Instance.GameStarted) {
			Midnight.GetComponent<RectTransform>().localPosition += Vector3.left * -FleeSpeed;
			Turbo.GetComponent<RectTransform>().localPosition += Vector3.left * FleeSpeed;
		}
	}
}

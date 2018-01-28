using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

	public Transform theCamera;
	public float FollowSpeed;
	private Vector3 posFollow, velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.Instance.GameStarted){
			posFollow = theCamera.position;
			transform.position = Vector3.SmoothDamp(transform.position, posFollow, ref velocity, FollowSpeed);
			//transform.position = theCamera.position;
		}
	}
}

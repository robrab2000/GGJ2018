using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(-GameManager.Instance.FlowRate.x * 0.5f,0,-Utils.ofMap(GameManager.Instance.FlowRate.y, 0f, 1f, 0.05f, 0.5f));
	}
}

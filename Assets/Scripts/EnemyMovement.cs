using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	private Vector2 moveDirection;
	private float moveSpeed;

	public float DefaultSpeed = 0.5f;

	// Use this for initialization
	void Start () {
		SetMoveDirection();
		StartCoroutine("ChangeDirection");
	}
	
	// Update is called once per frame
	void Update () {
		
		if (transform.position.y < 5f) {
			moveSpeed = 0;
			moveDirection = new Vector2(moveDirection.x, 0);
		}
		else if (transform.position.y > 25f) {
			moveSpeed = 0;
			moveDirection = new Vector2(moveDirection.x, 0);
		}
		else {
			moveSpeed = DefaultSpeed;
		}
		transform.Translate((-GameManager.Instance.FlowRate.x * 1f) + (moveDirection.x * moveSpeed),(moveDirection.y * moveSpeed),-Utils.ofMap(GameManager.Instance.FlowRate.y, 0f, 1f, 1.5f, 1.75f));

		if(transform.position.z < -20f) {
			Destroy(this.gameObject);
		}
	}

	IEnumerator ChangeDirection() {
		while(true){
			yield return new WaitForSeconds(Random.Range(1f,3.5f));
			SetMoveDirection();
		}
		
	}

	void SetMoveDirection() {
		moveDirection = new Vector2(Random.Range(-3f,3f), Random.Range(-1f,1f));
		print(moveDirection.y);
		moveSpeed = DefaultSpeed;// Random.Range(05f, 3f);
	}
}

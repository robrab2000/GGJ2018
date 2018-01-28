using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class CameraMovement : MonoBehaviour {

	Transform camTrans;
	public Transform StartPoint;
	public float IntroCamSpeed;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

	private bool Starting = false;

	// Use this for initialization
	void Start () {
		camTrans = this.transform;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameManager.Instance.GameStarted){
			float push;
			if(camTrans.position.y < 2f) {
				push = Mathf.Clamp(GameInput.Instance.verticalAxis2, -1f,0f);
			}
			else if(camTrans.position.y > 20) {
				push = Mathf.Clamp(GameInput.Instance.verticalAxis2, 0f, 1f);
			}
			else {
				push = GameInput.Instance.verticalAxis2;
			}
			camTrans.Translate(new Vector3(0, push * -0.35f, 0));
		}
		else {
			StartSequence();
		}
		CameraRotation();
	}

	void CameraRotation() {
		Quaternion rotation = Quaternion.Euler(camTrans.rotation.x, camTrans.rotation.y, GameInput.Instance.horizontalAxis1 * -5);
		camTrans.rotation = Quaternion.Lerp(camTrans.rotation, rotation, Time.time * smoothTime);
		GetComponent<Camera>().fieldOfView = Mathf.Lerp(50f,60f, Time.time * GameManager.Instance.FlowRate.y * smoothTime);
		var blur = Camera.main.GetComponent<MotionBlur>();
		blur.blurAmount = Mathf.Lerp(0.2f,0.4f, Time.time * GameManager.Instance.FlowRate.y * smoothTime);
	}

	void StartSequence() {


		//Transform posFollow = StartPoint.position;
		//transform.position = Vector3.SmoothDamp(transform.position, posFollow, ref velocity, FollowSpeed);

		//camTrans.position = Vector3.SmoothDamp(StartPoint.position, camTrans.position, ref velocity, smoothTime);
		camTrans.position = Vector3.Lerp(camTrans.position, StartPoint.position, Time.deltaTime * IntroCamSpeed);
		camTrans.rotation = Quaternion.Lerp(camTrans.rotation, StartPoint.rotation, Time.deltaTime * IntroCamSpeed);
	}
}

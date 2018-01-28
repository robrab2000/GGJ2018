using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleField : MonoBehaviour {

	public ParticleSystem FlowField;
	private ParticleSystem.EmitParams emitParams = new ParticleSystem.EmitParams();

	// Use this for initialization
	void Start () {
		InvokeRepeating("FieldFlowin",0,0.1f);
	}
	
	// Update is called once per frame
	void FieldFlowin () {
		//emitParams.velocity = new Vector3(0,0, GameManager.Instance.FlowRate.y);
		// int emmittion = (int)(GameManager.Instance.FlowRate.y * 10) + 1;
		// print(emmittion + " : " + -2000.0f * GameManager.Instance.FlowRate.y);
		
        // emitParams.velocity = new Vector3(0.0f, 0.0f, 2000.0f * GameManager.Instance.FlowRate.y);
		// FlowField.Emit(emitParams, emmittion);
		var emitParams = new ParticleSystem.EmitParams();
        emitParams.position = new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), 0.0f);
        emitParams.velocity = new Vector3(0.0f, 0.0f, 200.0f * GameManager.Instance.FlowRate.y);
        FlowField.Emit(emitParams, 1);
	}
}

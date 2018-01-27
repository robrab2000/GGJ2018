using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterControl : MonoBehaviour {

	public ParticleSystem[] Thrusters;
	private ParticleSystem.EmitParams frontEmitParams, backEmitParams = new ParticleSystem.EmitParams();

	void Update()
	{
		foreach (ParticleSystem t in Thrusters){
			t.Emit(frontEmitParams, (int)(50 * GameManager.Instance.FlowRate.y) + 5);
		}
		
	}
}

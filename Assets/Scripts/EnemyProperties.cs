using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProperties : MonoBehaviour {

	public float Health;
	public ParticleSystem hitParticles;
	private ParticleSystem.EmitParams emitParams = new ParticleSystem.EmitParams();

	public GameObject DeathThing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Health < 0) {
			Instantiate(DeathThing, transform.position, transform.rotation);
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "bullet") {
			hitParticles.Emit(emitParams, 2);
			Health--;
		}
	}
}

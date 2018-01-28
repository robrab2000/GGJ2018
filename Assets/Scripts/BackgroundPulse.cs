using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPulse : MonoBehaviour {


	public float[] samples = new float[128]; 

	private Renderer myRenderer;
	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		AudioListener.GetSpectrumData (samples, 0, FFTWindow.Hamming);
		float all = 0f;
		foreach (float f in samples) {
			all += f;
		}
		float final = (all / samples.Length) * 100;

		myRenderer.material.color = new Color(1,1,1, final);
		
	}
}

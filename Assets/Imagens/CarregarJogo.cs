using UnityEngine;
using System.Collections;

public class CarregarJogo : MonoBehaviour {

	public ParticleSystem particle;
	void OnMouseEnter()
	{
		gameObject.renderer.material.color = Color.yellow;
		particle.Play ();
	}
	
	
	void OnMouseExit()
	{
		
		renderer.material.color = Color.white;
		particle.Stop ();
	}
}

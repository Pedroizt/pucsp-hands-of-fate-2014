using UnityEngine;
using System.Collections;

public class ScriptNovoJogo : MonoBehaviour {
	


	public ParticleSystem particle;

	public bool Fadeout = false;





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

	void OnMouseDown()
	{
		Fadeout = true;
		AsyncOperation async1 = Application.LoadLevelAsync (2);


	}






}

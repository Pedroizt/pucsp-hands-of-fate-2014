using UnityEngine;
using System.Collections;

public class Sair : MonoBehaviour {

	public ParticleSystem particle;

	public MouseSounds MouseSounds;
	
	void Start(){
		
		GameObject a = GameObject.Find ("MouseSounds");
		MouseSounds = a.GetComponent <MouseSounds> ();
		
	}

	void OnMouseEnter()
	{
		gameObject.renderer.material.color = Color.yellow;
		particle.Play ();
		
		MouseSounds.OnMouse ();

	}
	
	
	void OnMouseExit()
	{
		
		renderer.material.color = Color.white;
		particle.Stop ();
	}

	void OnMouseDown()
	{
		MouseSounds.MouseClick ();
		Application.Quit ();
	}
}

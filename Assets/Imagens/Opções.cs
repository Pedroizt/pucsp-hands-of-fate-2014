﻿using UnityEngine;
using System.Collections;

public class Opções : MonoBehaviour {

	public ParticleSystem particle;

	public audioplay MouseSounds;
	
	void Start(){
		
		GameObject a = GameObject.Find ("MouseSounds");
		MouseSounds = a.GetComponent <audioplay> ();
		
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
		
	}

}

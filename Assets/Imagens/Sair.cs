using UnityEngine;
using System.Collections;

public class Sair : MonoBehaviour {


	//O script abaixo e utilizado para sair do jogo.
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

	//Ao clicar no objeto, o jogo e fechado.
	void OnMouseDown()
	{
		MouseSounds.MouseClick ();
		Application.Quit ();
	}
}

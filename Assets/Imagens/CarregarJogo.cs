using UnityEngine;
using System.Collections;

public class CarregarJogo : MonoBehaviour {


	//O script abaixo nao esta terminado, ele se trata do carregar jogo, apenas o som de mouse over 
	//e sua cor sao alterados no momento.
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

	}


}

using UnityEngine;
using System.Collections;

public class ScriptNovoJogo : MonoBehaviour {
	
	public ParticleSystem particle;

	public bool loading = false;

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
		/*Fadeout = true;
		AsyncOperation async1 = Application.LoadLevelAsync (2);*/
		loading = true;
		//screenFader.guiTexture.color = Color.Lerp(guiTexture.color, Color.black, Time.deltaTime);

		MouseSounds.MouseClick ();



	}









}

using UnityEngine;
using System.Collections;

public class ScriptNovoJogo : MonoBehaviour {

	//Script utilizado no objeto NovoJogo.
	public ParticleSystem particle;//Particulas que saem do mouse.

	public bool loading = false;//bool para controle que auxilia na tela de loading.

	public MouseSounds MouseSounds;//Objeto que armazena sons do mouse.

	void Start(){

		//O gameobject a seguir foi inicializado para conseguir componente de outro script utilizando
		//a variavel ja declarada.
		GameObject a = GameObject.Find ("MouseSounds");
		MouseSounds = a.GetComponent <MouseSounds> ();

	}


	//Caso exista a colisao do mouse com o objeto, a particula passa a existir e a cor do objeto muda.

	void OnMouseEnter()
	{
		gameObject.renderer.material.color = Color.yellow;
		particle.Play ();

		MouseSounds.OnMouse ();

	}
	
	//Caso contrario, a cor volta ao normal e a particula para.
	void OnMouseExit()
	{

		renderer.material.color = Color.white;
		particle.Stop ();
	}

	//Caso o objeto tenha sido clicado, a bool de loading sera acionada e o som de mouse disparado.
	void OnMouseDown()
	{
		/*Fadeout = true;
		AsyncOperation async1 = Application.LoadLevelAsync (2);*/
		loading = true;
		//screenFader.guiTexture.color = Color.Lerp(guiTexture.color, Color.black, Time.deltaTime);

		MouseSounds.MouseClick ();



	}









}

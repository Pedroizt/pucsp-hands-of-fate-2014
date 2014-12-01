using UnityEngine;
using System.Collections;

public class OtherHistoryControl : MonoBehaviour {

	//O script a seguir e usado para controlar a sequencia de partes da historia do jogo.

	//public Camera camera;
	public int parts; //Quantas partes de texto existem?
	public GameObject[] Partes;//Array que armazena todos os textos.
	//public string level;
	public int i = 0; //Auxilio no controle de array.
	//AsyncOperation async;
	//public GameObject background;
	//public TextMesh text1;
	//public bool clear = false;
	public GameObject scene; //Armazena todos os objetos da cena.
	public bool control;//Auxilia no controle do final da historia, impedindo que o objeto seja destruido varias vezes.
	/*public bool começacutscene = false;
	bool fimdoarray = false;
	bool disable = false;
	
	public SihirSounds Music;
	
	public Color collor2;
	
	bool music_running = false;*/

	// Use this for initialization
	void Start () {


		Partes [i].renderer.enabled = true;
		//O i esta armazenando atualmente qual objeto ira ser renderizado ao inicializar o script.
	
	
	}
	
	// Update is called once per frame
	void Update () {



		//Caso o botao seja usado, e o i seja menor que as partes do array, o i e incrementado, 
		//tirando a renderizaçao do objeto anterior e renderizando o atual.
		if (Input.GetButtonDown("Trigger") && i < parts) {

			i += 1;
			Partes [i].renderer.enabled = true;
			Partes [i - 1].renderer.enabled = false;
				
		}

		//caso o i tenha chegado ao valor igual das partes do array, a cena inteira sera destruida, voltado ao inventario
		//o controle impede que a cena continue sendo destruida.
		if (i >= parts)
		{
			if (control == false)
		{
				Destroy(scene);
			control = true;
			}
		}




	
	}

	
}

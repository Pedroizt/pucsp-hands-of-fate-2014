using UnityEngine;
using System.Collections;

public class MenuFade : MonoBehaviour {

	//O script a seguir e um script de controle de Fade de objetos, especificamente do menu inicial.


	public bool loadscreeen = false; //bool usada para controlar o inicio da tela de loading.
	bool StartScene = true; //bool usada para controlar o inicio da cena.
	//Variaveis usadas para conseguir variaveis de outros scripts.
	private ScriptNovoJogo newgame; 
	private LoadScreen loader;

	// Use this for initialization
	void Start () {

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject n = GameObject.Find ("NovoJogo");
		newgame = n.GetComponent<ScriptNovoJogo> ();

		GameObject l = GameObject.Find ("LoadScreen");
		loader = l.GetComponent<LoadScreen> ();




	}
	
	// Update is called once per frame
	void Update () {
	
		/*Caso a bool StartScene seja verdadeira, ela executara as seguintes linhas. Usando o Color.Lerp, ele
		 * trara da cor atual e ira "limpar" ela, zerando seu alpha. Caso o alpha da imagem seja menor ou igual
		 * 0.05f, a bool StartScene se tornara falsa, parando essa condiçao.*/
		if (StartScene) {
						guiTexture.color = Color.Lerp (guiTexture.color, Color.clear, Time.deltaTime);
			if (guiTexture.color.a <= 0.05f)
				StartScene = false;
		}


		/*Caso a variavel de loading do script "ScriptNovoJogo" seja ativada, a cor atual do objeto voltara 
		 * a ser negro, e quando seu alpha estiver ou ultrapassar os 0.95f, a bool loadscreen se tornara verdadeira 
		 * e objeto desse script sera destruido.*/
		  
		  if (newgame.loading == true && loadscreeen == false) {
						guiTexture.color = Color.Lerp (guiTexture.color, Color.black, 5* Time.deltaTime);
						if (guiTexture.color.a >= 0.95f)
			{
			
							loadscreeen = true;
				Destroy(gameObject);
			}

						

		}

			
	}


}

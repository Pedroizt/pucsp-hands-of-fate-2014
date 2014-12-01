using UnityEngine;
using System.Collections;

public class LoadScreen : MonoBehaviour {


	//O script a seguir controla a tela de loading que acontece no inicio do jogo.

	//public string LeveltoLoad;
	AsyncOperation async; //Utilizado para controlar o carregamento da cena.
	//bool test2; 
	public GameObject background; //Armazena o background da tela de loading.
	public TextMesh text1;//Armazena a porcentagem da tela de loading.
	public bool clear = false;//Controla caso o fade ja tenha terminado.
	public GameObject progressbar;//Imagem que representa o progresso do jogo.
	bool test = false;//Controlar o carregamento da cena.
	//Variaveis usadas para conseguir variaveis de outros scripts.
	private ScriptNovoJogo novojogo;
	private MenuFade Fade;

	private int LoadProgress = 0;//Por onde começa o progresso do loading.



	// Use this for initialization
	void Start () {

		// a bool inicializada começa como falsa.
		bool test = false;

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject n = GameObject.Find ("NovoJogo");
		novojogo = n.GetComponent<ScriptNovoJogo> ();

		GameObject f = GameObject.Find ("screenfader");
		Fade = f.GetComponent<MenuFade> ();

		//tudo que pertence ao loading e inativo no inicio do jogo.
		background.SetActive (false);
		text1.renderer.enabled = false;
		progressbar.SetActive (false);



	
	}

	// Update is called once per frame
	void Update () {


				//caso a bool do MenuFade seja verdadeira, e a bool de controle for falsa, uma coroutine sera executada
				// a qual e o loading. A partir disso, a bool de controle e tomada como false para que o mesmo metodo nao seja executado outra vez.
				if (Fade.loadscreeen == true) {

						if (test == false) {
								clear = true;

								StartCoroutine (DisplayLoadScreen ());
								test = true;
						}








	
				}
		}


		/*A coroutine abaixo descreve a loading screen, seus objetos sao ativados, o texto que se trata da porcentagem se torna
		 * equivalente ao objeto progressbar que cresce durante o carregamento da cena. Caso o mesmo carregamento esteja completo
		 * a proxima cena sera carregada*/

		IEnumerator DisplayLoadScreen ()
	{


		background.SetActive (true);
		text1.renderer.enabled = true;
		progressbar.SetActive (true);

		progressbar.transform.localScale = 
			new Vector3 (progressbar.transform.localScale.x, 
			             progressbar.transform.localScale.y, LoadProgress);
		text1.text = LoadProgress + "%";




		async = Application.LoadLevelAsync (2);

						while (!async.isDone) {
								LoadProgress = (int)(async.progress * 110);
								text1.text = LoadProgress + "%";
								progressbar.transform.localScale = 
				new Vector3 (progressbar.transform.localScale.x, 
				                                       
				             progressbar.transform.localScale.y, async.progress);

			yield return null;
							

						}








				



	}
}



using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	//Principal script de menu.
	public Color collor1; //Trata-se do armazenamento da cor do logo.

	//A seguir sao os objetos publicos que constituem o menu.
	public GameObject Logo;
	public GameObject NewGame;
	public GameObject LoadGame;
	public GameObject Options;
	public GameObject Exit;

	//Bool criada para controlar o aparecimento do logo.
	public bool fadein = false;

	// Use this for initialization
	void Start () {

		//A cor do logo vai ser controlada pela variavel collor1, que possui alpha 0.0f (Ou seja, ele esta invisivel).
		collor1 = Logo.renderer.material.color;
		collor1.a = 0.0f;

		//Pelo fato de nao poder desativar diretamente o objeto de novojogo por motivos de script, ele esta invisivel, junto com o collider.
		NewGame.collider.enabled = false;
		NewGame.renderer.enabled = false;
		//Objetos inicializados estao invisiveis.
		LoadGame.SetActive (false);
		Options.SetActive (false);
		Exit.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		//Uma coroutine começa a ser utilizada, criada para que o logo apareça lentamente, acionando a bool necessaria para isso.
		StartCoroutine (AparecerLogo ());

		//Caso a bool acionada pela coroutine seja verdadeira, o alpha do logo começa a crescer com o passar dos segundos.
		if (fadein == true)
						collor1.a += 0.1f * Time.deltaTime;
		//Caso o alpha do objeto esteja maior ou igual a 1.0, seu alpha para de crescer e o menu aparece.
		if (collor1.a >= 1.0f) {
			collor1.a = 1.0f;
						AparecerMenu ();
				}

		//para atualizar sempre o material do logo.
		Logo.renderer.material.color = collor1;

		/*if (Input.GetKeyDown (KeyCode.F)) {
			collor1.a = 1.0f;
			fadein = true;

				}*/
	
	}

	//coroutine usada para controlar a bool.
	IEnumerator AparecerLogo()
	{
		yield return new WaitForSeconds (5);
		fadein = true;

	}

	//metodo chamado no update apos o alpha se tornar 1.0f, modificando a visibilidade dos objetos.
	void AparecerMenu()
	{
		NewGame.collider.enabled = true;
		NewGame.renderer.enabled = true;
		LoadGame.SetActive (true);
		Options.SetActive (true);
		Exit.SetActive (true);
	}
}

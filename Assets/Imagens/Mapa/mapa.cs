using UnityEngine;
using System.Collections;

public class mapa : MonoBehaviour {

	//O script atual se trata do mapa do jogo.
	public GameObject map; //Mapa
	public GameObject[] nuvens;//array que armazena as nuvens do jogo.
	public Inventario invent;//Coleta informaçoes do inventario.
	public bool ismap = false; //checagem do mapa
	public bool isinventario = false;//checagem do inventario.

	public GameObject[] triggers;//armazenamento de triggers.

	//Nuvens que cobrem o mapa.
	bool notcloud1 = false;
	bool notcloud2 = false;
	bool notcloud3 = false;
	bool notcloud4 = false;
	//Controle para que o mapa nao abra durante a cutscene
	private CutsceneControl opening;




	// Use this for initialization
	void Start () {

		//O mapa esta desabilitado.
		map.renderer.enabled = false;
		nuvens[0].renderer.enabled = false;
		nuvens[1].renderer.enabled = false;
		nuvens[2].renderer.enabled = false;
		nuvens[3].renderer.enabled = false;

		GameObject c = GameObject.Find ("Opening Cutscene");
		opening = c.GetComponent<CutsceneControl> ();




	
	}
	
	// Update is called once per frame
	void Update () {

		//Caso o comando de mapa seja usado, apenas abre se o inventario n estiver aberto
		//ou quando nao existe mais a cutscene inicial.
		if(Input.GetButtonDown("Mapa") && isinventario == false && opening.jogoinicia == true)
		{
			ismap = !ismap; //Ligar ou desligar o mapa.


			if (ismap == true)
			{
				Time.timeScale = 0; //Pause.
				DrawMap();//Habilitar o mapa.


			}



			else//Unpause.
			{
				DontDrawMap();
				Time.timeScale = 1;
			}

		}




	
	}

	void DrawMap()//Habilitar o mapa e as nuvens, caso tenha pisado na trigger, a nuvem da trigger nao sera
		//renderizada mais.
	{
		map.renderer.enabled = true;

		if (notcloud1 == false)
		nuvens[0].renderer.enabled = true;
		if (notcloud2 == false)
		nuvens[1].renderer.enabled = true;
		if (notcloud3 == false)
		nuvens[2].renderer.enabled = true;
		if (notcloud4 == false)
		nuvens[3].renderer.enabled = true;
	}

	public void DontDrawMap()//Desabilitar o mapa.
	{
		map.renderer.enabled = false;

			nuvens[0].renderer.enabled = false;

			nuvens[1].renderer.enabled = false;

			nuvens[2].renderer.enabled = false;

			nuvens[3].renderer.enabled = false;
	}

	//Bools para controle das nuvens.
	void DonDrawCloud1()
	{
		Debug.Log ("Teste");
		notcloud1 = true;
	}
	void DonDrawCloud2()
	{
		notcloud2 = true;
	}
	void DonDrawCloud3()
	{
		notcloud3 = true;
	}
	void DonDrawCloud4()
	{
		notcloud4 = true;
	}



}

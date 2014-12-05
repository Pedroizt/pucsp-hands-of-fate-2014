using UnityEngine;
using System.Collections;

public class Hpsih : MonoBehaviour {

	//Um dos scripts principais, determina os atributos do personagem.
	public float maxHealth =  10f; //Vida maxima da personagem.
	public float curHealth =  10f; //Vida atual da personagem.
	public float HealthRegen = 0.125f; //Regeneraçao de vida por segundo
	//As variaveis a seguir tratam-se da vida da personagem.
	public GameObject maxH;
	public GameObject AlmostMaxH;
	public GameObject HalfH;
	public GameObject AlmostEmptyH;
	public GameObject Empty;
	//As variaveis a seguir, sao utilizadas para conseguir componentes de outros scripts
	private Fade fd;
	private Inventario pause;
	public bool paused = false;
	private HistoriaControl history;
	private CutsceneControl cutsc;

	public bool Damaged = false; //bool para controle de invencibilidade apos o dano.
	public SihirSounds SihirSounds; //Objeto para controlar os sons.

	public bool counterEnable = false;//Contador para auxiliar o som de batimento cardiaco.
	public float counter = 4;	
	public bool already_music = false;
		
		

	// Use this for initialization
	void Start () {

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject f = GameObject.Find ("screenFader");
		fd = f.GetComponent<Fade> ();

		GameObject h = GameObject.Find ("OpeningHistory");
		history = h.GetComponent<HistoriaControl> ();

		GameObject i = GameObject.Find ("inventario 2");
		pause = i.GetComponent<Inventario> ();

		GameObject c = GameObject.Find ("Opening Cutscene");
		cutsc = c.GetComponent<CutsceneControl> ();

		GameObject v = GameObject.Find ("Sihir");
		SihirSounds = v.GetComponent<SihirSounds> ();




		//No inicio do jogo apenas a vida maxima dela esta ativada..
		maxH.SetActive (true);
		AlmostMaxH.SetActive (false);
		HalfH.SetActive (false);
		AlmostEmptyH.SetActive (false);
		Empty.SetActive (false);



	
	}
	
	// Update is called once per frame
	void Update () {

		//Caso a vida atual dela seja diferente de sua vida maxima e diferente de 0, ela ganha regeneraçao de vida.
		if (curHealth != maxHealth && curHealth != 0f) {
			curHealth += HealthRegen * Time.deltaTime;
				}
		//Caso a a vida atual seja maior que a vida maxima dela, sua vida atual sempre sera sua vida maxima.
		if (curHealth > maxHealth)
						curHealth = maxHealth;
		//Caso a vida atual seja menor ou igual a 0. sua vida atual sempre sera 0 e o fade de gameover acontecera.
		if (curHealth <= 0) {
						curHealth = 0;
			fd.gameOver = true;
				}
		//Caso ela tenha recebido um dano, ela nao recebera outro imediatamente, chamando uma coroutine.
		if (Damaged == true) {
			Invencibilidade();
				}

		ReducaoHp ();//Caso seu HP seja reduzido.



		//Contador para batimento cardiaco.
		if (counterEnable) 
		{
			if (counter >= 4)
			{
				HeartBeatingSound();
				counter = 0;
				
			}
			counter += Time.deltaTime;

			
		}

	
	}


	void ReducaoHp(){
	
		//Ao sua vida diminuir, quando nao esta pausado ou na cutscene atual, sua vida troca de cor
		//com base na vida atual dela, sendo proporiconal a vida maxima.
		if (pause.isPause == false && history.começacutscene == true && cutsc.jogoinicia == true) {
							
			if (!already_music)
			{
				SihirSounds.ErasMusic ();		
				already_music = true;

			}



						if (curHealth >= maxHealth || curHealth > maxHealth / 1.25f)
			{
				maxH.SetActive (true);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
				if (counterEnable == true)
				{
					counter = 4;
					counterEnable = false;
					SihirSounds.StopHeart();
				}
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), maxH);

						if (curHealth <= maxHealth / 1.25 && curHealth > maxHealth / 2f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (true);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
				if (counterEnable == true)
				{
					counter = 4;
					counterEnable = false;
					SihirSounds.StopHeart();
				}
			}

								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), AlmostMaxH);

						if (curHealth <= maxHealth / 2f && curHealth > maxHealth / 4f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (true);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (false);
				if (counterEnable == true)
				{
					counter = 4;
					counterEnable = false;
					SihirSounds.StopHeart();
				}
				
			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), HalfH);

						if (curHealth <= maxHealth / 4f && curHealth > maxHealth / 10f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (true);
				Empty.SetActive (false);
				HeartBeatingSound();//Batimento cardiaco começa ocorrer



			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), AlmostEmptyH);

						if (curHealth <= maxHealth / 10f && curHealth >= 0f)
			{
				maxH.SetActive (false);
				AlmostMaxH.SetActive (false);
				HalfH.SetActive (false);
				AlmostEmptyH.SetActive (false);
				Empty.SetActive (true);
				HeartBeatingSound();

			}
								//GUI.DrawTexture (new Rect (Screen.width - 790, Screen.height - 580, 80, 100), Empty);
				}

		//Caso nada disso aconteça, estara tudo desabilitado.
		else
		{
			maxH.SetActive (false);
			AlmostMaxH.SetActive (false);
			HalfH.SetActive (false);
			AlmostEmptyH.SetActive (false);
			Empty.SetActive (false);
		}


	}

	void Invencibilidade() //Ela so podera tomar dano quando a bool voltar ao seu estago original apos um segundo.
	{
		StartCoroutine (Fimdainv ());
	}

	IEnumerator Fimdainv()
	{
		yield return new WaitForSeconds(1);
		Damaged = false;
	}


	void HeartBeatingSound ()
	{
		if (counter >= 3.98f) 
		{
			SihirSounds.Heartbeating() ;
			counterEnable = true;
		}

	}


	
	
	/*IEnumerator HealthRegeneration()
	{


	}*/
}

using UnityEngine;
using System.Collections;

public class HistoriaControl : MonoBehaviour {

	//Controle da cutscene inicial do jogo, funciona do mesmo modo que OtherHistoryControl.
	public Camera camera;
	public GameObject Imagem1;
	public GameObject Imagem2;
	public GameObject Imagem3;
	public GameObject AperteF;
	public GameObject[] Partes = new GameObject[22];
	public int i = 0;
	public bool começacutscene = false;
	bool fimdoarray = false;
	bool disable = false;

	public SihirSounds Music;

	public Color collor2;

	bool music_running = false;


	// Use this for initialization
	void Start () {




		Partes [i].renderer.enabled = true;

		collor2 = Imagem3.renderer.material.color;
		collor2.a = 1.0f;

		GameObject y = GameObject.Find ("Sihir");
		Music = y.GetComponent <SihirSounds> ();



	
	}
	
	// Update is called once per frame
	void Update () {

		if (!music_running) {

			Music.History_Music ();
			music_running = true;
		}


		if (disable == false)
		Partes [i].renderer.enabled = true;


		if (fimdoarray == false) {
						if (Input.GetButtonDown("Trigger")) {
								i += 1;
								
								Partes [i - 1].renderer.enabled = false;
						}
				}





		if (i == 21) {
			//Imagem3.renderer.enabled = false;
			fimdoarray = true;

			if (começacutscene == false)
			collor2.a -= 0.1f * Time.deltaTime * 2;

			if (fimdoarray == true)
			{
				Partes[i].renderer.enabled = false;
				AperteF.renderer.enabled = false;

				Music.StopHistory();


					disable = true;
			}
					



			if (collor2.a <= 0.05f)
			{
				Imagem3.renderer.enabled = false;
				camera.enabled = false;
						
						começacutscene = true;
			}
				}

		if (i == 9) {
						Imagem1.renderer.enabled = false;
			Imagem2.renderer.enabled = true;
				}

		if (i == 17) {
			Imagem2.renderer.enabled = false;
			Imagem3.renderer.enabled = true;

				}

		Imagem3.renderer.material.color = collor2;
		 




	
	}
}

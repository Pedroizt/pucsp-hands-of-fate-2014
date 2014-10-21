using UnityEngine;
using System.Collections;

public class HistoriaControl : MonoBehaviour {

	public GameObject Imagem1;
	public GameObject Imagem2;
	public GameObject Imagem3;
	public GameObject[] Partes = new GameObject[22];
	public int i = 0;
	public bool começacutscene = false;
	bool fimdoarray = false;
	bool disable = false;

	public Color collor2;


	// Use this for initialization
	void Start () {

		Partes [i].renderer.enabled = true;
		collor2 = Imagem3.renderer.material.color;
		collor2.a = 1.0f;


	
	}
	
	// Update is called once per frame
	void Update () {



		if (disable == false)
		Partes [i].renderer.enabled = true;


		if (fimdoarray == false) {
						if (Input.GetKeyDown (KeyCode.F)) {
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
				

					disable = true;
			}
					



			if (collor2.a <= 0.05f)
			{
				Imagem3.renderer.enabled = false;

						
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

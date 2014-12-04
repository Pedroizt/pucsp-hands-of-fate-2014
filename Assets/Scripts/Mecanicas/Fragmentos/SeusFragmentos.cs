using UnityEngine;
using System.Collections;

public class SeusFragmentos : MonoBehaviour
{

		//Classe para armazenar quantos fragmentos de memoria voce tem.
		public int SihFrags = 0;
		public int AurFrags = 0;
		public int HistFrags = 0;
		public int MythFrags = 0;
		public GameObject SPrologo;
		public GameObject SInterrogacaoP;
		public GameObject SCap1;
		public GameObject SInterrogacao1;
		public GameObject SCap2;
		public GameObject SInterrogacao2;
		public GameObject SCap3;
		public GameObject SInterrogacao3;
		public GameObject SCap4;
		public GameObject SInterrogacao4;
		public GameObject SEpilogo;
		public GameObject SInterrogacao1E;
		public GameObject TextBProl;
		public GameObject TextBCap1;
		public GameObject TextBCap2;
		public GameObject TextBCap3;
		public GameObject TextBCap4;
		public GameObject TextBEpil;
		public bool paused = false;
		bool once1 = false;
		bool once2 = false;
		bool once3 = false;
		bool once4 = false;
		bool once5 = false;
		bool once6 = false;
		GameObject RealCamera;
		public GameObject Textbox;
	public GameObject Continue;

	void Start()
	{
		RealCamera = GameObject.Find("RealCamera");
		Textbox.SetActive (false);
		Continue.SetActive (false);
	}

		void Update ()
		{
				if (SihFrags == 1 && once1 == false) {
						
						SInterrogacaoP.SetActive (false);
						SPrologo.SetActive (true);
						TextBProl.SetActive (true);
						once1 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

			    			
			    		
						
				}

				if (SihFrags == 5 && once2 == false) {
						SInterrogacao1.SetActive (false);
						SCap1.SetActive (true);
						TextBCap1.SetActive (true);
						once2 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

				}
				

				if (SihFrags == 10 && once3 == false) {
						SInterrogacao2.SetActive (false);
						SCap2.SetActive (true);
						TextBCap2.SetActive (true);
						
						once3 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

						
				}

				if (SihFrags == 15 && once4 == false) {
						SInterrogacao3.SetActive (false);
						SCap3.SetActive (true);
						TextBCap3.SetActive (true);
						
						once4 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

				}
				

				if (SihFrags == 20 && once5 == false) {
						SInterrogacao4.SetActive (false);
						SCap4.SetActive (true);
						TextBCap4.SetActive (true);
					
						once5 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

				}
				

				if (SihFrags == 25 && once6 == false) {
						SInterrogacao1E.SetActive (false);
						SEpilogo.SetActive (true);
						TextBEpil.SetActive (true);
						
						once6 = true;
						Time.timeScale = 0;
						paused = true;
			Textbox.SetActive (true);
			Continue.SetActive (true);

				}
				



				if (Input.GetButtonDown ("Trigger") && paused == true) {
						Time.timeScale = 1;
						TextBProl.SetActive (false);
						TextBCap1.SetActive (false);
						TextBCap2.SetActive (false);
						TextBCap3.SetActive (false);
						TextBCap4.SetActive (false);
						TextBEpil.SetActive (false);	
						Textbox.SetActive (false);
			Continue.SetActive (false);
			paused = false;

				}
					



		}

		

}

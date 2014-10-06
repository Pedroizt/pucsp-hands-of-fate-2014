using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {




	public string espaço = "";
	public string selo;


	// Use this for initialization
	void Start(){
		}
	
	// Update is called once per frame
	void Update() {

				if (Input.GetKeyDown (KeyCode.Keypad0)) {
						espaço += "0";
				} else if (Input.GetKeyDown (KeyCode.Keypad1)) {
						espaço += "1";
				} else if (Input.GetKeyDown (KeyCode.Keypad2)) {
						espaço += "2";
				} else if (Input.GetKeyDown (KeyCode.Keypad3)) {
						espaço += "3";
				} else if (Input.GetKeyDown (KeyCode.Keypad4)) {
						espaço += "4";
				} else if (Input.GetKeyDown (KeyCode.Keypad5)) {
						espaço += "5";
				} else if (Input.GetKeyDown (KeyCode.Keypad6)) {
						espaço += "6";
				} else if (Input.GetKeyDown (KeyCode.Keypad7)) {
						espaço += "7";
				} else if (Input.GetKeyDown (KeyCode.Keypad8)) {
						espaço += "8";
				} else if (Input.GetKeyDown (KeyCode.Keypad9)) {
						espaço += "9";
				} else if (espaço.Length >= 6) {
			
						espaço = "";
				} else if (Input.GetKeyDown (KeyCode.Backspace)) {
			
						espaço = "";
				} 
		
				if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			
						selo = espaço;
						espaço = "";
			
			
				}



				/*if (selo == "83") {
						Object obj = Instantiate (Impacto, transform.position, transform.rotation);
						selo = "";
						

				} */

		}/*else if (selo == "01") {
			Object obj = Instantiate (_desoxig, transform.position, transform.rotation);
			selo = "";
			Destroy (obj, 1);
				}*/







		/*
		  else if (selo == "980") {
			Object obj = Instantiate (_Acido, transform.position, transform.rotation);
			selo = "";
			Destroy (obj, 1);
			
		}

		else if (selo == "17935") {
			Object obj = Instantiate (_Raiodovazio, transform.position, transform.rotation);
			selo = "";
			Destroy (obj, 1);
			
		}

		else if (selo == "7777") {
			Object obj = Instantiate (_Agua, transform.position, transform.rotation);
			selo = "";
			Destroy (obj, 1);
			
		}
		

		
				

		}

	void OnGUI (){
		GUI.Box(new Rect (250, 470, 300, 20), espaço);
		
		
		
		
	}*/

	/*void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Rocha")
						Destroy (col.gameObject);
	}*/

/*} else if (selo == "141") {
	
	
	
} else if (selo == "2300") {
	Object obj = Instantiate (sacredblast, transform.position, transform.rotation);
	AudioSource.PlayClipAtPoint(scsound, transform.position);
	AudioSource.PlayClipAtPoint(_s, transform.position);
	selo = "";
	Destroy (obj, 1);
} else if (selo == "400") {
	
	Object obj = Instantiate (eruption, transform.position, transform.rotation);
	AudioSource.PlayClipAtPoint(erupsound, transform.position);
	AudioSource.PlayClipAtPoint(_e, transform.position);
	selo = "";
	Destroy (obj,1);
	
}*/

	
}



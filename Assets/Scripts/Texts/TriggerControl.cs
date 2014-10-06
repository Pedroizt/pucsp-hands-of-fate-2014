using UnityEngine;
using System.Collections;

public class TriggerControl : MonoBehaviour {

	private TextControl text;
	bool Once1 = true;
	bool Once2 = true;
	bool Once3 = true;
	bool Once4 = true;
	bool Once5 = true;
	bool Once6 = true;
	bool Once7 = true;
	bool Once8 = true;
	bool Once9 = true;
	bool Once10 = true;
	bool Once11 = true;






	
	// Use this for initialization
	void Start () {

		GameObject t = GameObject.Find ("Texbox/TEXTBOX");
		text = t.GetComponent<TextControl> ();


	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(){

			if (gameObject.tag == "1" && Once1) {


						text.um.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "2" && Once2) {


						text.dois.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "3" && Once3) {


						text.tres.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
			Debug.Log("Funfa");
				}

			if (gameObject.tag == "4" && Once4) {


						text.quatr.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "5" && Once5) {


						text.cin.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
			Debug.Log("Funfa");
				}

			if (gameObject.tag == "6" && Once6) {

						text.sei.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
			Debug.Log("Funfa");
				}

			if (gameObject.tag == "7" && Once7) {


						text.sete.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "8" && Once8) {


						text.oito.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "9" && Once9) {


						text.nov.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "10" && Once10) {


						text.dez.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

			if (gameObject.tag == "11" && Once11) {
		

						text.onze.gameObject.renderer.enabled = true;
			text.textbox.gameObject.renderer.enabled = true;
				}

	
	}

	void OnTriggerExit()
	{

		text.textbox.gameObject.renderer.enabled = false;

				if (gameObject.tag == "1" && Once1) {
						text.um.gameObject.renderer.enabled = false;

			Once1 = false;
				}
				
				if (gameObject.tag == "2" && Once2) {
			Once2 = false;
			text.dois.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "3" && Once3) {
			Once3 = false;
			text.tres.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "4" && Once4) {
			Once4 = false;
			text.quatr.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "5" && Once5) {
			Once5 = false;
			text.cin.gameObject.renderer.enabled = false;
				}

				
				if (gameObject.tag == "6" && Once6) {

			text.sei.gameObject.renderer.enabled = false;
						Once6 = false;
				}
				
				if (gameObject.tag == "7" && Once7) {
			Once7 = false;
			text.sete.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "8" && Once8) {
			Once8 = false;
			text.oito.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "9" && Once9) {
			Once9 = false;
			text.nov.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "10" && Once10) {
			Once10 = false;
			text.dez.gameObject.renderer.enabled = false;
				}
				
				if (gameObject.tag == "11" && Once11) {
			Once11 = false;
			text.onze.gameObject.renderer.enabled = false;
				}

	}


}

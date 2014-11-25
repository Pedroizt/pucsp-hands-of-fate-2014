using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour
{


		public TextMesh spelltext;
		public Transform cameratarget;
		public string espaço = "";
		public string selo;
		private Inventario pause;
		public Transform trsihir;
		bool already_pressed;
		public float counter = 0;
		


		/*Corrigir bug do inventário
- Refinar as triggers de ajuda
- Colocar feedback da magia
- Camera
- Cutscenes
- Historia
- Menu interno
- Agua
- (Talvez opções)
- Bug do loadscreen
-
há 12 minutos
corrigir bug de morrer no pause*/


		// Use this for initialization
		void Start ()
		{
				GameObject i = GameObject.Find ("inventario 2");
				pause = i.GetComponent<Inventario> ();

				already_pressed = false;
				
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (pause.isPause == false) {
						spellnumbers ();
						spellarrows ();
						showtext ();
						spellcolors ();
				}

				gameObject.transform.rotation = cameratarget.transform.rotation;


				if (already_pressed) {

						counter += Time.deltaTime;
						if (counter >= 0.3f) {

								already_pressed = false;
								counter = 0;
						}

				}
			
		}

		void spellnumbers ()
		{
				if (Input.GetKeyDown (KeyCode.Keypad0) || (Input.GetKeyDown (KeyCode.Alpha0))) {
						espaço += "0";
				} else if (Input.GetKeyDown (KeyCode.Keypad1) || (Input.GetKeyDown (KeyCode.Alpha1))) {
						espaço += "1";
				} else if (Input.GetKeyDown (KeyCode.Keypad2) || (Input.GetKeyDown (KeyCode.Alpha2))) {
						espaço += "2";
				} else if (Input.GetKeyDown (KeyCode.Keypad3) || (Input.GetKeyDown (KeyCode.Alpha3))) {
						espaço += "3";
				} else if (Input.GetKeyDown (KeyCode.Keypad4) || (Input.GetKeyDown (KeyCode.Alpha4))) {
						espaço += "4";
				} else if (Input.GetKeyDown (KeyCode.Keypad5) || (Input.GetKeyDown (KeyCode.Alpha5))) {
						espaço += "5";
				} else if (Input.GetKeyDown (KeyCode.Keypad6) || (Input.GetKeyDown (KeyCode.Alpha6))) {
						espaço += "6";
				} else if (Input.GetKeyDown (KeyCode.Keypad7) || (Input.GetKeyDown (KeyCode.Alpha7))) {
						espaço += "7";
				} else if (Input.GetKeyDown (KeyCode.Keypad8) || (Input.GetKeyDown (KeyCode.Alpha8))) {
						espaço += "8";
				} else if (Input.GetKeyDown (KeyCode.Keypad9) || (Input.GetKeyDown (KeyCode.Alpha9))) {
						espaço += "9";
				} else if (espaço.Length >= 6) {
			
						espaço = "";
				} else if (Input.GetButtonDown ("Backspace")) {
			
						espaço = "";
				} 
		
				if (Input.GetButtonDown ("Cast"))
		    
						FinishMagic ();

		}

		public void spellarrows ()
		{
				if (!already_pressed) {

						if (Input.GetAxis ("DPad Horizontal") > 0.1f) {
								espaço += "R ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Horizontal") < -0.1f) {
								espaço += "L ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Vertical") > 0.1f) {
								espaço += "U ";
								already_pressed = true;
						}
						if (Input.GetAxis ("DPad Vertical") < -0.1f) {
								espaço += "D ";
								already_pressed = true;
						}
						
				}

		}

		public void FinishMagic ()
		{

				selo = espaço;
				espaço = "";
		
		}

		void showtext ()
		{
				
				if (spelltext == null)
						Debug.Log ("Esqueceu de colocar o SpellText");

				spelltext.text = espaço;
				

		}

		/*void showarrows{
		
}*/

		void spellcolors ()
		{
				
				if (espaço == "01" || espaço == "83" || espaço == "10" || espaço == "D R " || espaço == "U L "
		    || espaço == "R D ")
						spelltext.color = Color.blue;
				else
						spelltext.color = Color.red;
				
		}



			


	
}



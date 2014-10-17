using UnityEngine;
using System.Collections;

public class SpellCast : MonoBehaviour {


	public TextMesh spelltext;
	public Transform cameratarget;
	public string espaço = "";
	public string selo;


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
	void Start(){
		}
	
	// Update is called once per frame
	void Update() {

		spellnumbers ();
		showtext ();

				

	


		}

	void spellnumbers()
	{
		if (Input.GetKeyDown (KeyCode.Keypad0) || (Input.GetKeyDown(KeyCode.Alpha0))) {
			espaço += "0";
		} else if (Input.GetKeyDown (KeyCode.Keypad1)|| (Input.GetKeyDown(KeyCode.Alpha1))) {
			espaço += "1";
		} else if (Input.GetKeyDown (KeyCode.Keypad2)|| (Input.GetKeyDown(KeyCode.Alpha2))) {
			espaço += "2";
		} else if (Input.GetKeyDown (KeyCode.Keypad3)|| (Input.GetKeyDown(KeyCode.Alpha3))) {
			espaço += "3";
		} else if (Input.GetKeyDown (KeyCode.Keypad4)|| (Input.GetKeyDown(KeyCode.Alpha4))) {
			espaço += "4";
		} else if (Input.GetKeyDown (KeyCode.Keypad5)|| (Input.GetKeyDown(KeyCode.Alpha5))) {
			espaço += "5";
		} else if (Input.GetKeyDown (KeyCode.Keypad6)|| (Input.GetKeyDown(KeyCode.Alpha6))) {
			espaço += "6";
		} else if (Input.GetKeyDown (KeyCode.Keypad7)|| (Input.GetKeyDown(KeyCode.Alpha7))) {
			espaço += "7";
		} else if (Input.GetKeyDown (KeyCode.Keypad8)|| (Input.GetKeyDown(KeyCode.Alpha8))) {
			espaço += "8";
		} else if (Input.GetKeyDown (KeyCode.Keypad9)|| (Input.GetKeyDown(KeyCode.Alpha9))) {
			espaço += "9";
		} else if (espaço.Length >= 6) {
			
			espaço = "";
		} else if (Input.GetKeyDown (KeyCode.Backspace)) {
			
			espaço = "";
		} 
		
		if (Input.GetKeyDown (KeyCode.KeypadEnter) || (Input.GetMouseButtonDown(0))) {
			
			selo = espaço;
			espaço = "";


			
			
		}
		}

	void showtext()
	{
		if (spelltext == null)
						Debug.Log ("Esqueceu de colocar o SpellText");

		spelltext.text = espaço;


	}


	
	void FixedUpdate()
	{


		gameObject.transform.rotation = cameratarget.transform.rotation; 

						
		
	}

	
}



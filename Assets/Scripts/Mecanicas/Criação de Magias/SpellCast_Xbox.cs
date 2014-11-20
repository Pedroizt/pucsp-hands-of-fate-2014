using UnityEngine;
using System.Collections;

public class SpellCast_Xbox : MonoBehaviour {

	public TextMesh spelltext;
	public Transform cameratarget;
	public string espaço = "";
	public string selo;
	private Inventario pause;
	
	

	
	
	// Use this for initialization
	void Start(){
		GameObject i = GameObject.Find ("inventario 2");
		pause = i.GetComponent<Inventario> ();
	}
	
	// Update is called once per frame
	void Update() {
		
		if (pause.isPause == false) {
			showtext ();
			spellcolors();
		}
		
		
		
		
		
		
	}
	
	public void DDpad ()
	{
			espaço += "0";
	} 


	public void UDpad()
	{
			espaço += "1";
	} 
	/*else if (Input.GetKeyDown (KeyCode.Keypad2)|| (Input.GetKeyDown(KeyCode.Alpha2))) {
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
		} */
		



	
	void showtext()
	{
		if (spelltext == null)
			Debug.Log ("Esqueceu de colocar o SpellText");
		
		spelltext.text = espaço;
		
		
	}
	
	void spellcolors()
	{
		if (espaço == "01" || espaço == "83" || espaço == "10")
			spelltext.color = Color.blue;
		else
			spelltext.color = Color.red;
	}
	
	
	
	void FixedUpdate()
	{
		
		
		gameObject.transform.rotation = cameratarget.transform.rotation; 
		
		
		
	}
	

}

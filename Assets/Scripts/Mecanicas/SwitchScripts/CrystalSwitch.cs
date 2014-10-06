using UnityEngine;
using System.Collections;

public class CrystalSwitch : MonoBehaviour {

	bool EstaSwitch = false;
	bool naofucionamais = false;
	public float vel = 2.0f;
	private CristalGrande cgrande;


	// Use this for initialization
	void Awake () {

		gameObject.renderer.material.color = Color.red;

		Debug.Log ("bool e falsa");

		GameObject c = GameObject.Find ("CristalGrande");
		cgrande = c.GetComponent<CristalGrande> ();
	
	}
	
	// Update is called once per frame
	void Update () {

				transform.Rotate (0, vel, 0);
		        
					
				

	
				}
		

	 void OnTriggerStay(Collider col){
		EstaSwitch = true;

		if(col.gameObject.tag == "Player" && EstaSwitch == true)
		{
		if (Input.GetKeyDown (KeyCode.F) && naofucionamais == false) {
			Debug.Log ("Teste");
			gameObject.renderer.material.color = Color.blue;
			gameObject.tag = "On";
			cgrande.Start ();
			Debug.Log ("bool e verdadeira");
			naofucionamais = true;
			vel = 0;
		}




	}
}

	void OnTriggerExit(){
		EstaSwitch = false;
		print (EstaSwitch);
	}





}


using UnityEngine;
using System.Collections;

public class CrystalSwitch : MonoBehaviour {

	bool EstaSwitch = false;
	bool naofucionamais = false;
	public float vel = 2.0f;

	private CristalGrande cgrande;
	public GameObject F;

	// Use this for initialization
	void Awake () {

		gameObject.renderer.material.color = Color.red;




		F.SetActive (false);

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


			if (Input.GetButtonDown("Trigger")&& naofucionamais == false)
			{
			Debug.Log ("Teste");
			gameObject.renderer.material.color = Color.blue;
			gameObject.tag = "On";
			cgrande.Start ();

			
			naofucionamais = true;
			vel = 0;
				F.SetActive(false);





		}
			if (naofucionamais == false)
				F.SetActive(true);






	}
}

	void OnTriggerExit(){
		EstaSwitch = false;
		F.SetActive (false);
		print (EstaSwitch);
	}





}


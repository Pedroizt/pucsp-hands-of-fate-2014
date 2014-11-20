using UnityEngine;
using System.Collections;

public class CrystalSwitch : MonoBehaviour {

	bool EstaSwitch = false;
	bool naofucionamais = false;
	public float vel = 2.0f;
	public ParticleSystem glow;
	private CristalGrande cgrande;
	public GameObject F;
	Xbox360_Controls XboxButton;

	// Use this for initialization
	void Awake () {

		gameObject.renderer.material.color = Color.red;
		glow.renderer.enabled = true;;



		F.SetActive (false);

		GameObject x = GameObject.Find ("XboxControl");
		XboxButton = x.GetComponent <Xbox360_Controls> ();

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


		if ((Input.GetKeyDown (KeyCode.F) && naofucionamais == false)
			    || (XboxButton.PressedButton == "B" && naofucionamais == false))
			{
			Debug.Log ("Teste");
			gameObject.renderer.material.color = Color.blue;
			gameObject.tag = "On";
			cgrande.Start ();
				glow.renderer.enabled = false;
			
			naofucionamais = true;
			vel = 0;
				F.SetActive(false);


				XboxButton.NullButton ();



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


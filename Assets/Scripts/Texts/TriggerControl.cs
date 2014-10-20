using UnityEngine;
using System.Collections;

public class TriggerControl : MonoBehaviour {


	bool Once1 = true;
	bool Once2 = true;
	bool Once3 = true;
	bool Once4 = true;
	bool Once5 = true;
	bool Once6 = true;

	bool check1 = false;
	bool check2 = false;
	bool check3 = false;
	bool check4 = false;
	bool check5 = false;
	bool check6 = false;



	public ParticleSystem torre1;
	public ParticleSystem torre2;
	public ParticleSystem torre3;
	public ParticleSystem torre4;
	public ParticleSystem torre5;
	public ParticleSystem torre6;






	
	// Use this for initialization
	void Start () {



		torre1.renderer.enabled = true;
		torre2.renderer.enabled = false;
		torre3.renderer.enabled = false;
		torre4.renderer.enabled = false;
		torre5.renderer.enabled = false;
		torre6.renderer.enabled = false;



	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(){

			if (gameObject.tag == "1" && Once1) {

			torre1.renderer.enabled = false;
			//Once1 = false;
			check1 = true;
			torre2.renderer.enabled = true;

				}

		if (gameObject.tag == "2" && Once2) {
			torre2.renderer.enabled = false;
			//Once2 = false;
			check2 = true;
			torre3.renderer.enabled = true;
				}

		if (gameObject.tag == "3" && Once3 ) {

			torre3.renderer.enabled = false;
			//Once3 = false;
			check3 = true;
			torre4.renderer.enabled = true;
				}

		if (gameObject.tag == "4" && Once4) {
			torre4.renderer.enabled = false;
			//Once4 = false;
			check4 = true;
			torre5.renderer.enabled = true;
				}

			if (gameObject.tag == "5" && Once5) {

			torre5.renderer.enabled = false;
			//Once5 = false;
			check5 = true;
			torre6.renderer.enabled = true;

				}

		if (gameObject.tag == "6" && Once6 && check5 == true) {
			torre6.renderer.enabled = false;
			check6 = true;
			Once6 = false;
				}

			

	
	}




}

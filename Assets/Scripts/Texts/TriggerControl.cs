﻿using UnityEngine;
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
	public ParticleSystem ptorre1;
	public ParticleSystem torre2;
	public ParticleSystem ptorre2;
	public ParticleSystem torre3;
	public ParticleSystem ptorre3;
	public ParticleSystem torre4;
	public ParticleSystem ptorre4;
	public ParticleSystem torre5;
	public ParticleSystem ptorre5;
	public ParticleSystem torre6;
	public ParticleSystem ptorre6;






	
	// Use this for initialization
	void Start () {



		torre1.renderer.enabled = true;
		torre2.renderer.enabled = false;
		torre3.renderer.enabled = false;
		torre4.renderer.enabled = false;
		torre5.renderer.enabled = false;
		torre6.renderer.enabled = false;

		ptorre1.renderer.enabled = true;
		ptorre2.renderer.enabled = false;
		ptorre3.renderer.enabled = false;
		ptorre4.renderer.enabled = false;
		ptorre5.renderer.enabled = false;
		ptorre6.renderer.enabled = false;



	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){

			if (gameObject.tag == "1" && Once1 && col.gameObject.tag == "Player") {

			torre1.renderer.enabled = false;
			ptorre1.renderer.enabled = false;
			//Once1 = false;
			check1 = true;
			torre2.renderer.enabled = true;
			ptorre2.renderer.enabled = true;

				}

		if (gameObject.tag == "2" && Once2&& col.gameObject.tag == "Player") {
			torre2.renderer.enabled = false;
			ptorre2.renderer.enabled = false;
			//Once2 = false;
			check2 = true;
			torre3.renderer.enabled = true;
			ptorre3.renderer.enabled = true;
				}

		if (gameObject.tag == "3" && Once3 && col.gameObject.tag == "Player") {

			torre3.renderer.enabled = false;
			ptorre3.renderer.enabled = false;
			//Once3 = false;
			check3 = true;
			torre4.renderer.enabled = true;
			ptorre4.renderer.enabled = true;
				}

		if (gameObject.tag == "4" && Once4&& col.gameObject.tag == "Player") {
			torre4.renderer.enabled = false;
			ptorre4.renderer.enabled = false;
			//Once4 = false;
			check4 = true;
			torre5.renderer.enabled = true;
			ptorre5.renderer.enabled = true;
				}

		if (gameObject.tag == "5" && Once5&& col.gameObject.tag == "Player") {

			torre5.renderer.enabled = false;
			ptorre5.renderer.enabled = false;
			//Once5 = false;
			check5 = true;
			torre6.renderer.enabled = true;
			ptorre6.renderer.enabled = true;

				}

		if (gameObject.tag == "6" && Once6 && check5 == true&& col.gameObject.tag == "Player") {
			torre6.renderer.enabled = false;
			check6 = true;
			Once6 = false;
				}

			

	
	}




}

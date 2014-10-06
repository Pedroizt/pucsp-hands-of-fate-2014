using UnityEngine;
using System.Collections;

public class InstanciarEscada : MonoBehaviour {

	private CriarEscada instancia;
	public Object escada;
	bool existe = false;



	// Use this for initialization
	void Start () {

		GameObject g = GameObject.Find ("Cube");
		instancia = g.GetComponent<CriarEscada> ();



	

	
	}
	
	// Update is called once per frame
	void Update () {


		if (existe == false && instancia.semescadas == false) {
						Instantiate (escada, transform.position, transform.rotation);
			existe = true;



				}


	
	}
}

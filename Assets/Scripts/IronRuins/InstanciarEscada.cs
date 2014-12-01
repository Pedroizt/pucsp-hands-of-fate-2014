using UnityEngine;
using System.Collections;

public class InstanciarEscada : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	 * FUNÇAO: Criaria uma escada para o jogador.*/
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

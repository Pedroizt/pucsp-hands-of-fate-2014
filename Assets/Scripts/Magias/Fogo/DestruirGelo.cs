using UnityEngine;
using System.Collections;

public class DestruirGelo : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	 * FUNCAO: Destruir objetos do tipo gelo.*/
	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Gelo") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

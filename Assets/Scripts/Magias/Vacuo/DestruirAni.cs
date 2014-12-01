using UnityEngine;
using System.Collections;

public class DestruirAni : MonoBehaviour {


	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE ULTIMA FASE E PENULTIMO FEITIÇO.
	 * FUNÇAO: Destruir quaisquer objetos com a tag "Anissita", possibilitaria destruir outros tipos de objeto.*/
	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Anissita") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

using UnityEngine;
using System.Collections;

public class DestruirFogo : MonoBehaviour {


	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE ULTIMA FASE. NAO IMPLEMENTADO
	 * FUNCAO: Outro modo de destruir o fogo, na teoria, junto com o mesmo feitiço, e com o de ar, poderia destruir
	 * metal. */
	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Fogo") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

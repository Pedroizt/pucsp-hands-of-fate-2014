using UnityEngine;
using System.Collections;

public class CampoDesx : MonoBehaviour {
	
	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: Sua funçao esta agora no Desoxigen.cs.
	 * FUNCAO: Destruir objetos do tipo fogo.. */
	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Fogo") {
			Destroy (col.gameObject);

		}

	}
}

using UnityEngine;
using System.Collections;

public class TriggerBlock : MonoBehaviour {


	/*SCRIPT NÃO UTILIZADO
	MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	FUNÇAO: Peso necessario para quebrar o bloco*/
	private VariaveisBloco breaking;
	// Use this for initialization

	void Start () {

		GameObject b = GameObject.Find ("VariavelBloco");
		breaking = b.GetComponent<VariaveisBloco> ();


	
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider col)
	{
		if (col.gameObject.tag == "Player" 
		    && col.gameObject.rigidbody.mass >= 9999) {
			
			Debug.Log ("Funcionou1");
			
			Destroy (breaking.respawn.gameObject);
			

}
	}
}
	
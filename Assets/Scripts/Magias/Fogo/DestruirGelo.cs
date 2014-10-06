using UnityEngine;
using System.Collections;

public class DestruirGelo : MonoBehaviour {

	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Gelo") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

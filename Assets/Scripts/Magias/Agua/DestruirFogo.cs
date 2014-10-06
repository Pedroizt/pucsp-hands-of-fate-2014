using UnityEngine;
using System.Collections;

public class DestruirFogo : MonoBehaviour {

	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Fogo") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

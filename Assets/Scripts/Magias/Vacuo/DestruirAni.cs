using UnityEngine;
using System.Collections;

public class DestruirAni : MonoBehaviour {

	void OnCollisionEnter (Collision col) 
	{ 
		if (col.gameObject.tag == "Anissita") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		}
		
		
		
	}
}

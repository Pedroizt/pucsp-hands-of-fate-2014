using UnityEngine;
using System.Collections;

public class CampoDesx : MonoBehaviour {
	

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Fogo") {
			Destroy (col.gameObject);

		}

	}
}

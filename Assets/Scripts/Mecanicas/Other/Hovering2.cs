using UnityEngine;
using System.Collections;

public class Hovering2 : MonoBehaviour {

	float hoverforce = 100;
	float variacao = 1;
	public bool switchon = false;
	
	
	void OnTriggerStay (Collider col)
	{
		if (switchon == true)
			gameObject.tag = "Hovering";
		
		if (gameObject.tag == "Hovering")
			col.rigidbody.AddForce (Vector3.up * hoverforce);
	}
	
	
	
	
	
}

using UnityEngine;
using System.Collections;

public class FallObject : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		gameObject.rigidbody.useGravity = true;
	}

	void OnCollisionEnter(Collision collision)
	{
		Destroy (gameObject);
	
	}
}

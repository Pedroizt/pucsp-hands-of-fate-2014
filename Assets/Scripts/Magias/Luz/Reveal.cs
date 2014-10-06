using UnityEngine;
using System.Collections;

public class Reveal : MonoBehaviour {

	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "NoCollision")
						col.renderer.enabled = false;

		else if (col.gameObject.tag == "Invisivel")
			col.renderer.enabled = true;
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "NoCollision") {
						col.renderer.enabled = true;
				}

		else if (col.gameObject.tag == "Invisivel")
			col.renderer.enabled = false;

	}
}


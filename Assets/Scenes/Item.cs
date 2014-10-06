using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	private PassSwitch pass;
	// Use this for initialization
	void Start () {

		GameObject p = GameObject.Find ("WindSwitch");
		pass = p.GetComponent<PassSwitch> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (pass.ativado == false)
						gameObject.renderer.material.color = Color.red;
		if (pass.ativado == true) {
						gameObject.renderer.material.color = Color.blue;
			if (Input.GetMouseButtonDown(0))
				Destroy (gameObject);

				}


	
	}
}

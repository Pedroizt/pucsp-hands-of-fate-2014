using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	//SCRIPT NAO UTILIZADO.
	//MOTIVO: O SCRIPT A SEGUIR E O DA SEGUNDA FASE, NAO IMPLEMENTADA.
	//O script a seguir seria um item que apenas pode eer coletado quando a switch for ativada.
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

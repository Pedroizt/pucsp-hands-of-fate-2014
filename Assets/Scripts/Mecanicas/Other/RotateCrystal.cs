using UnityEngine;
using System.Collections;

public class RotateCrystal : MonoBehaviour {

	/*public bool naogirou = true;
	bool naopodegirarmais = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider col)
	{
		if (naopodegirarmais == false) {
						if (col.gameObject.tag == "Player") {
								if (Input.GetKeyDown (KeyCode.F)) {
										naogirou = false;
					naopodegirarmais = true;
								}
			
			
						}
				}


	
	}*/

	public bool girou;

	void Update()
	{
		if (!girou)
				if (Input.GetKeyDown (KeyCode.F)) {
						girou = true;
			Debug.Log("girou a switch");
				} else if (girou) {
			if (Input.GetKeyDown(KeyCode.F))
				girou = false;
			Debug.Log("nao girou a switch");
				}
						

	}
}

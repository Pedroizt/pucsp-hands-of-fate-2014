using UnityEngine;
using System.Collections;

public class GirarObjeto : MonoBehaviour {

	bool girou = false;
	bool naogirou = true;
	private Rotate r1;
	// Use this for initialization
	void Start () {

		GameObject r = GameObject.Find ("Switch");
		r1 = r.GetComponent<Rotate> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (naogirou == true && r1.naogirou == true && r1.girou == false) {
						gameObject.transform.Rotate (0, 90, 0);
						girou = true;
			naogirou = false;
				} else if (girou == true && r1.girou == true && r1.naogirou == false) {
						gameObject.transform.Rotate (0, -90, 0);
			girou = false;
			naogirou = true;
				}


	
	}
}

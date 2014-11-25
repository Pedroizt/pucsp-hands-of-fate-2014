using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {


	float vel = 2f;
	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (0, 0, vel);

						

		

		
	
	}

	void OnTriggerStay(Collider col){
		if (col.gameObject.tag == "Player") {
			if (Input.GetButtonDown("Trigger")){
				vel = 0;
			}
				}
		
	}




}

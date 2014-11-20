using UnityEngine;
using System.Collections;

public class Sihir : MonoBehaviour {

	public Animator anim;

	public GameObject camera;


	Vector3 sihir;


	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
						anim.SetBool ("Andar", true);
						gameObject.transform.position += transform.forward;
						


				} else
						anim.SetBool ("Andar", false);

		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, camera.transform.localEulerAngles.y, transform.localEulerAngles.z); 
	
	}
}

using UnityEngine;
using System.Collections;

public class Sihir : MonoBehaviour {

	public Animator anim;

	public GameObject camera;

	public audioplay SihirSounds;

	Vector3 sihir;


	void Start () {
	
		#region Audio
		GameObject a = GameObject.Find ("SihirSounds");
		SihirSounds = a.GetComponent <audioplay> ();
		#endregion

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
						anim.SetBool ("Andar", true);
						gameObject.transform.position += transform.forward;
						

						SihirSounds.SihirFootsteps (); //Footsteps Sound

				} else
						anim.SetBool ("Andar", false);

		transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, camera.transform.localEulerAngles.y, transform.localEulerAngles.z); 
	
	}
}

using UnityEngine;
using System.Collections;

public class TrueSihir : MonoBehaviour
{


		public bool nojump;
		public Animator anim;
		public float jumpforce = 5;
		public float speed = 10;
		public float smooth = 2;
		float resetspeed = 10;
		float progressivespeed = 0.2f;
		float resetprogressivespeed = 0.2f;
		public GameObject camera;
		private Rigidbody rb;

		// Use this for initialization
		void Start ()
		{

				rb = GetComponent<Rigidbody> ();
	
		}
	
		// Update is called once per frame
		void LateUpdate ()
		{

		
				if (Input.GetKey (KeyCode.W)) {
						anim.SetBool ("_run", true);
						gameObject.transform.position += transform.forward * speed * Time.deltaTime;
						speed += progressivespeed * Time.deltaTime;


						
						anim.speed = speed / 6.5f;
						

						
						

						if (speed > 11)
								progressivespeed = 0;
						  
			
						//SihirSounds.SihirFootsteps (); //Footsteps Sound
			
				} else {
						anim.SetBool ("_run", false);
						speed = resetspeed;


				anim.speed = speed / 10f;
						progressivespeed = 0.1f;
						
				}
		
				transform.localEulerAngles = 
			new Vector3 (transform.localEulerAngles.x, 
		                                         
			     camera.transform.localEulerAngles.y 
		                                         , transform.localEulerAngles.z); 

				if (Input.GetKeyDown (KeyCode.Space)) {
						if (nojump == false) {
								nojump = true;
								rb.AddForce (Vector3.up * jumpforce, ForceMode.VelocityChange);
								anim.SetTrigger ("_jump");
								rb.useGravity = false;
								
						}
						
				} else
						
						rb.useGravity = true;
				

						
				
		}

		void OnCollisionEnter (Collision col)
		{

						
				

				if (col.gameObject.tag == "Terrain")
						nojump = true;
				else {
						nojump = false;

				}
		}



		/*void progressivespeed()
	{
		while (speed < 5)
						speed += 0.2f * 0.01f * Time.deltaTime;
	}*/


	
}




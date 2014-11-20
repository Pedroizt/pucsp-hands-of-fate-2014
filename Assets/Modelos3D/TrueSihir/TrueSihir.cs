using UnityEngine;
using System.Collections;

public class TrueSihir : MonoBehaviour
{


		public float vel;
		public bool damaged = false;
		public bool attacking;
		public bool nojump;
		public Animator anim;
		public float jumpforce = 7;
		public float speed = 10;
		public float smooth = 2;
		public float resetspeed = 7;
		float progressivespeed = 0.2f;
		float resetprogressivespeed = 0.2f;
		public GameObject camera;
		private Rigidbody rb;
		//public audioplay SihirSounds;
		float pos;
		bool walking;
		bool sidewalk;
		bool lateral;
		bool jumped = false;
		public Animator dado1;
		public Animator dado2;
		public Animator dado3;
		public Animator dado4;
		public bool collided;
		public ParticleSystem bursts;
		float cd;
		bool pressedS;
		bool pressedW;

		public SihirSounds SihirSounds;


		// Use this for initialization
		void Start ()
		{

				/*GameObject a = GameObject.Find ("SihirSounds");
				SihirSounds = a.GetComponent <audioplay> ();*/

				rb = GetComponent<Rigidbody> ();
				pos = 0f;
				pos = transform.localEulerAngles.y;

				#region Audio
				GameObject a = GameObject.Find ("SihirSounds");
				SihirSounds = a.GetComponent <SihirSounds> ();
				#endregion
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{


		
				walking = false;

				if (Input.GetKey (KeyCode.W) && 
		    attacking == false && pressedS == false && collided == false) {

						
		
						anim.SetBool ("_run", true);
						pressedW = true;		
								
						gameObject.transform.position += transform.forward * speed * Time.deltaTime;
						SihirSounds.SihirFootsteps(); //Footsteps Sound
						speed += progressivespeed * Time.deltaTime;


						
						anim.speed = speed / 6.5f;
						

						
						

						if (speed > 11)
								progressivespeed = 0;
						  
			
						
			
				} else {
						anim.SetBool ("_run", false);
						speed = resetspeed;


						anim.speed = speed / 10f;
						progressivespeed = 0.1f;
						
				}


				if (Input.GetKey (KeyCode.D) && Input.GetKey (KeyCode.W)) {
						walking = true;
						if (pos < 45f)

								pos += 5f * Time.deltaTime * vel;
				}

				if (Input.GetKey (KeyCode.D) && attacking == false && pressedS == false) {

						if (walking == false) {
								anim.SetBool ("_run", true);
								pos = 90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;
				sidewalk = true;

						}








		
				}

				if (Input.GetKey (KeyCode.A) && Input.GetKey (KeyCode.W)) {
						walking = true;
						if (pos >= -45f)

								pos -= 5f * Time.deltaTime * vel;
				}

				if (Input.GetKey (KeyCode.A) && attacking == false && pressedS == false) {
			
						if (walking == false) {
								anim.SetBool ("_run", true);
								pos = -90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;

				
						}
				}

				/*if (pos != 0 && Input.GetKey (KeyCode.W) && walking == false) {
			pos = 0;
				}*/

				if (Input.GetKey (KeyCode.W)) {
						if (pos >= 0f && walking == false)
								pos -= 1f * Time.deltaTime * vel * 2;


						if (pos <= 0f && walking == false)
								pos += 1f * Time.deltaTime * vel * 2;
		
				}



				
		
		 		

				transform.localEulerAngles = 
			new Vector3 (transform.localEulerAngles.x, 
		                                         
			     camera.transform.localEulerAngles.y + pos
		                                         , transform.localEulerAngles.z);

				

				if (Input.GetKeyDown (KeyCode.Space)) {
						if (nojump == true) {
								nojump = false;
								jumped = true;
								rb.AddForce (Vector3.up * jumpforce, ForceMode.VelocityChange);
								anim.SetTrigger ("_jump");
								rb.useGravity = false;
				speed = speed/2;
								
								
						}
						
				} else {
						
						rb.useGravity = true;
				}


				if (Input.GetKeyDown (KeyCode.F)) {
						if (attacking == false)
								Attack ();
				}

				if (Input.GetKeyDown (KeyCode.V)) {
						damaged = true;
				}
				
				if (Input.GetKey (KeyCode.S) && pressedW == false) {

						anim.SetBool ("_run", true);
						gameObject.transform.position -= transform.forward * Time.deltaTime * speed / 2;
						pressedS = true;

				}

				if (Input.GetKeyUp (KeyCode.S)) {
						pressedS = false;
				}

				if (Input.GetKeyUp (KeyCode.W))
						pressedW = false;
				

						
				
		}

		void OnCollisionEnter (Collision col)
		{

						
				

				if (col.gameObject.tag == "Terrain") {
						nojump = true;
						if (jumped == true)
				anim.SetTrigger("_grounded");
			speed = resetspeed;
			    //anim.SetBool("_grounded", false);
						Debug.Log ("Grounded");

				


						
						
						
				}

		if (col.gameObject.tag == "Untagged"){
			
			Debug.Log ("Collided");
			gameObject.transform.position -= transform.forward * 0.5f;
			collided = true;
			StartCoroutine(colcd());


		}


		
		
		
		}

		void OnCollisionExit (Collision col)
		{
				Debug.Log ("NotGrounded");
					;
				//jumped = true;
		}

		void Attack ()
		{
				anim.SetTrigger ("_attack");
				attacking = true;
				StartCoroutine (boolback ());
				dado1.SetTrigger ("attack");
				dado2.SetTrigger ("attack2");
				dado3.SetTrigger ("attack3");
				dado4.SetTrigger ("attack4");
				bursts.Play ();


		}

		IEnumerator boolback ()
		{
				yield return new WaitForSeconds (1.8f);
				attacking = false;
		}

		IEnumerator colcd()
		{
		yield return new WaitForSeconds(1);
		collided = false;
		}
	
	
	
	
	


		/*void progressivespeed()
	{
		while (speed < 5)
						speed += 0.2f * 0.01f * Time.deltaTime;
	}*/


	
}




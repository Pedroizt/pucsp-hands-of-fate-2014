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
		public float pos;
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
		int randomnumber;
		public bool counterEnable = false;
		public float counter_f = 0.4f;	
		public bool jumpsound;
		public float counter2 = 0;
		bool already_running = false;
		bool already_jumping = false;
		float counter_j;

		// Use this for initialization
		void Start ()
		{

				GameObject a = GameObject.Find ("Sihir");
				SihirSounds = a.GetComponent <SihirSounds> ();

				rb = GetComponent<Rigidbody> ();
				pos = 0f;
				pos = transform.localEulerAngles.y;
				jumpsound = true;

				
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{

		counter2 += Time.deltaTime;

		#region Som Risada
		if (counter2 >= 30) 
		{
			randomnumber = Random.Range (1, 6000);
			if (randomnumber == 666) {

				SihirSounds.PlaySound (2);
				counter2 = 0;

			}
		}
		#endregion


		#region Contador Passos
		if (counterEnable) 
		{
			if (counter_f >= 0.4f)
			{
				counter_f = 0;
				
			}
			counter_f += Time.deltaTime;
			
			
		}
		#endregion

				walking = false;

				banwalking ();

				if (Input.GetAxis("Vertical") > 0.1f && 
		    attacking == false && pressedS == false && collided == false) {

						
		
						
						//if(already_running == false)
						//{
							FootstepsSound();
						//	already_running=true;	
						//}
						anim.SetBool ("_run", true);
						pressedW = true;		
								
						gameObject.transform.position += transform.forward * speed * Time.deltaTime;
						speed += progressivespeed * Time.deltaTime;


						
						anim.speed = speed / 6.5f;
						

						
						

						if (speed > 11)
								progressivespeed = 0;
						  
			
						
			
				} else {
						anim.SetBool ("_run", false);
						speed = resetspeed;

						SihirSounds.StopFootsteps();
						already_running=false;
						anim.speed = speed / 10f;
						progressivespeed = 0.1f;
				
			
		}


		if (Input.GetAxis("Horizontal") > 0.1f && Input.GetAxis("Vertical") > 0.1f) {
						walking = true;
						if (pos < 45f)

								pos += 5f * Time.deltaTime * vel;
						
								
				 
				}

		if (Input.GetAxis("Horizontal") > 0.1f && attacking == false && pressedS == false) {

						if (walking == false) {

								//if(already_running == false)
								//{
									FootstepsSound();
								//	already_running=true;	
								//}
								anim.SetBool ("_run", true);
								pos = 90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;
								sidewalk = true;
								
							
						

						}


		} else{

				//SihirSounds.StopFootsteps();
				already_running = false;

			}

		if (Input.GetAxis("Horizontal") < -0.1f && Input.GetAxis("Vertical") > 0.1f) {
						walking = true;
						if (pos >= -45f)

								pos -= 5f * Time.deltaTime * vel;
				}

		if (Input.GetAxis("Horizontal") < -0.1f && attacking == false && pressedS == false) {
			
						if (walking == false) {
								//if(already_running == false)
								//{
									FootstepsSound();
								//	already_running=true;	
								//}
								anim.SetBool ("_run", true);
								pos = -90f;
								gameObject.transform.position += transform.forward 
										* speed * Time.deltaTime;
								

				
						}
				} else {
				
								
								//SihirSounds.StopFootsteps();
								already_running = false;
				
				}

				/*if (pos != 0 && Input.GetKey (KeyCode.W) && walking == false) {
			pos = 0;
				}*/

		if (Input.GetAxis("Vertical") > 0.1f) {
						if (pos >= 0f && walking == false)
								pos -= 1f * Time.deltaTime * vel * 2;


						if (pos <= 0f && walking == false)
								pos += 1f * Time.deltaTime * vel * 2;
		
				}



				
		
		 		

				transform.localEulerAngles = 
			new Vector3 (transform.localEulerAngles.x, 
		                                         
			     camera.transform.localEulerAngles.y + pos
		                                         , transform.localEulerAngles.z);

				

				if (Input.GetButtonDown("Jump")) {
						if (nojump == true) {
								nojump = false;
								jumped = true;
								rb.AddForce (Vector3.up * jumpforce, ForceMode.VelocityChange);
								anim.SetTrigger ("_jump");
								rb.useGravity = false;
								speed = speed / 2;
								already_jumping = true;
								#region Jump Sounds Switch
								if (jumpsound) {
										SihirSounds.PlaySound (3);
										jumpsound = false;
								} else {
										SihirSounds.PlaySound (4);
										jumpsound = true;
								}
								#endregion
						} 
				}else {
						
								rb.useGravity = true;						}

				/*
				if (Input.GetKeyDown (KeyCode.F)) {
						if (attacking == false)
								Attack ();
				}*/

				
				
				if (Input.GetAxis("Vertical") < -0.1f && pressedW == false) {

						anim.SetBool ("_run", true);
						gameObject.transform.position -= transform.forward * Time.deltaTime * speed / 2;
						pressedS = true;

				}

		if (Input.GetAxis("Vertical") < -0.1f) {
						pressedS = false;
				}

		if (Input.GetAxis("Vertical") > 0.1f)
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

		void Damage()
		{
		damaged = true;
		Debug.Log ("Correct");
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
	
	
	
		void FootstepsSound()
		{
			if (counter_f >= 0.39f) 
			{
				SihirSounds.Footstep_Sound();
				counterEnable = true;
			}
		}
	

		void banwalking () 
		{
			
			if (already_jumping) 
			{

			counter_j += Time.deltaTime;
			SihirSounds.MuteFootsteps();
			if(counter_j >= 1)
			{

				SihirSounds.UnMuteFootsteps();
				counter_j = 0;
				already_jumping = false;

			}
			}

		}
		/*void progressivespeed()
	{
		while (speed < 5)
						speed += 0.2f * 0.01f * Time.deltaTime;
	}*/


	
}




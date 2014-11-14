using UnityEngine;
using System.Collections;

public class TrueSihir : MonoBehaviour
{

	public bool damaged = false;
	public bool attacking;
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
		public audioplay SihirSounds;

		// Use this for initialization
		void Start ()
		{

		GameObject a = GameObject.Find ("SihirSounds");
		SihirSounds = a.GetComponent <audioplay> ();

				rb = GetComponent<Rigidbody> ();
	
		}
	
		// Update is called once per frame
		void Update ()
		{

		
				if (Input.GetKey (KeyCode.W) && attacking == false) {

								anim.SetBool ("_run", true);
								
								
								gameObject.transform.position += transform.forward * speed * Time.deltaTime;
								//SihirSounds.SihirFootsteps(); footstepssounds
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


		if (Input.GetKeyDown (KeyCode.F)) {
			Attack();
				}

		if (Input.GetKeyDown (KeyCode.D)) {
			damaged = true;
				}
				

						
				
		}

		void OnCollisionEnter (Collision col)
		{

						
				

				if (col.gameObject.tag == "Terrain")
						nojump = true;
				else {
						nojump = false;

				}
		}

	void Attack()
	{
		anim.SetTrigger ("_attack");
		attacking = true;
		StartCoroutine(boolback ());

	}



	IEnumerator boolback()
	{
		yield return new WaitForSeconds(2.5f);
		attacking = false;
	}







		/*void progressivespeed()
	{
		while (speed < 5)
						speed += 0.2f * 0.01f * Time.deltaTime;
	}*/


	
}




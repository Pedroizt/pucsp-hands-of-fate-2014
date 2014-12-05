using UnityEngine;
using System.Collections;

public class FollowEnemy : MonoBehaviour {

	bool once = false;
	bool reset = false;
	public float HP;
    float health;
	public float Damage;
	private Hpsih HPSihir;
	float Distancia;
	Transform Target;
	float VistaDistancia = 25.0f;
	float ChaseRange = 10.0f;
	float AttackRange = 1.0f;
	float MoveSpeed = 1.0f;
	float smoothing = 6.0f;
	private Animator hedgehog;
	//private CharacterController character;
	private Rigidbody character;
	private BoxCollider cols;
	public bool attacktime = false;
	GameObject childcol;
	Vector3 inipos;
	float pos;
	public ParticleSystem teste;
	SihirSounds Music;	
	bool already_music;
	bool still_battle;
	float counter_music = 0;




	void Start ()
	{
		Target = GameObject.Find ("Sihir/Target").transform ;

		GameObject h = GameObject.Find ("Sihir");
		HPSihir = h.GetComponent<Hpsih> ();
		Music = h.GetComponent<SihirSounds> ();
		still_battle = false;
		already_music = false;



		hedgehog = gameObject.GetComponent<Animator> ();
		/*character = gameObject.AddComponent<CharacterController> ();
		character.height = 0.01f;
		character.radius = 0.01f;*/
		/*character = gameObject.AddComponent<Rigidbody> ();
		character.useGravity = true;
		character.freezeRotation = true;
		cols = gameObject.AddComponent<BoxCollider> ();*/




		childcol = GameObject.Find ("bigcrush 1(Clone)/idle/Bip001");


		childcol.collider.enabled = true;
		health = HP;
		inipos = gameObject.transform.position;




		}
	
	// Update is called once per frame
	void Update () {

		Distancia = Vector3.Distance (Target.position, transform.position);
		//Distancia = new Vector3 (Target.position.x - transform.position.x);

		if (health >= 0) {
						if (Distancia < VistaDistancia) {


								hedgehog.SetBool ("walkin", false);
								hedgehog.SetBool ("idle", true);
								//renderer.material.color = Color.yellow;
								lookAt ();
								still_battle = false;
						}

						if (Distancia > VistaDistancia) {
			
								hedgehog.SetBool ("idle", true);
								//renderer.material.color = Color.grey;
				still_battle = false;
						}

						if (Distancia < AttackRange) {

								hedgehog.SetTrigger ("attack");
			
						} else if (Distancia < ChaseRange) {


								//renderer.material.color = Color.red;
								hedgehog.SetBool ("idle", false);
								hedgehog.SetBool ("walkin", true);


								
								chase ();
								
								
								if (!already_music)
								{
								Music.ErasMute ();
								Music.BattleMusic ();
								Music.BattleUnmute ();
								already_music = true;
								still_battle = true;
				}
								
							}
						
			

				}

		else {
			hedgehog.SetBool("idle", false);
			hedgehog.SetBool("walkin", false);
			hedgehog.SetBool("death", true);
			Invoke("Smoke", 1.3f);

				
			still_battle = false;
			Music.BattleMute();
			if (!still_battle)
			{
				
				counter_music += Time.deltaTime;
				if (counter_music >1.5f)
				{
					Music.ErasUnmute();
					counter_music = 0;
				}
				already_music = false;
				
			}


			if (once == false)
			{
			StartCoroutine(respawns());
				once = true;
			}

				}

		if (reset == true) {
			reset = false;
			foreach(Transform child in this.transform)
			{
				child.gameObject.SetActive (true);
			}
			health = HP;
			print(health);
			once = false;
			hedgehog.SetBool("death", false);
			hedgehog.SetTrigger("attack");
			gameObject.transform.position = inipos;

				}



	 
	}

	void lookAt()
	{

		Quaternion rotation = Quaternion.LookRotation (transform.position - Target.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation,Time.deltaTime * smoothing);

	}

	void Smoke()
	{
		teste.Play ();
	}




	void chase()
	{
		transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);


		//pos = -transform.forward.x * MoveSpeed * Time.deltaTime;
	}


	void ApplyDamage(float dano)
	{
		Debug.Log ("ApplyDamage");
		health -= dano;
		hedgehog.SetTrigger ("damage2");


						
						//gameObject.SetActive (false);

	}

	IEnumerator respawns()
	{
		yield return new WaitForSeconds (2);
		{
			foreach(Transform child in this.transform)
			{
						child.gameObject.SetActive (false);
			}
			yield return new WaitForSeconds(30);
			reset = true;

				}

	
	}













}

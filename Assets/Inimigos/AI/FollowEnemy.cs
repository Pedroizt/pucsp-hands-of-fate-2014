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
	public bool attacktime = false;
	GameObject childcol;
	Vector3 inipos;




	void Start ()
	{
		Target = GameObject.Find ("Senpai Notice Me").transform ;

		GameObject h = GameObject.Find ("Senpai Notice Me");
		HPSihir = h.GetComponent<Hpsih> ();

		hedgehog = gameObject.GetComponent<Animator> ();

		childcol = GameObject.Find ("bigcrush 1(Clone)/idle/Bip001");


		childcol.collider.enabled = true;
		health = HP;
		inipos = gameObject.transform.position;



		}
	
	// Update is called once per frame
	void Update () {

		Distancia = Vector3.Distance (Target.position, transform.position);

		if (health >= 0) {
						if (Distancia < VistaDistancia) {


								hedgehog.SetBool ("walkin", false);
								hedgehog.SetBool ("idle", true);
								//renderer.material.color = Color.yellow;
								lookAt ();
						}

						if (Distancia > VistaDistancia) {
			
								hedgehog.SetBool ("idle", true);
								//renderer.material.color = Color.grey;
						}

						if (Distancia < AttackRange) {

								hedgehog.SetTrigger ("attack");
								
			
						} else if (Distancia < ChaseRange) {


								//renderer.material.color = Color.red;
								hedgehog.SetBool ("idle", false);
								hedgehog.SetBool ("walkin", true);



								chase ();
						}
				}

		else {
			hedgehog.SetBool("idle", false);
			hedgehog.SetBool("walkin", false);
			hedgehog.SetBool("death", true);


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




	void chase()
	{
		transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
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
			yield return new WaitForSeconds(3);
			reset = true;

				}
	}













}

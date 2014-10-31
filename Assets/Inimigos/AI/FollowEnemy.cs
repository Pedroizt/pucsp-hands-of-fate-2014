using UnityEngine;
using System.Collections;

public class FollowEnemy : MonoBehaviour {

	private SpawnRespawn respawn;
	public float HP;
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


	void Start ()
	{
		Target = GameObject.Find ("Senpai Notice Me").transform ;

		GameObject h = GameObject.Find ("Senpai Notice Me");
		HPSihir = h.GetComponent<Hpsih> ();

		hedgehog = gameObject.GetComponent<Animator> ();

		childcol = GameObject.Find ("bigcrush 1(Clone)/idle/Bip001");


		childcol.collider.enabled = true;




		}
	
	// Update is called once per frame
	void Update () {

		Distancia = Vector3.Distance (Target.position, transform.position);

		if (HP >= 0) {
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
		HP -= dano;
		hedgehog.SetTrigger ("damage2");

	}










}

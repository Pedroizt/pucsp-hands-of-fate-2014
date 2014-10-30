using UnityEngine;
using System.Collections;

public class FollowEnemy : MonoBehaviour {

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
	bool attacktime = false;

	void Start ()
	{
		Target = GameObject.Find ("Senpai Notice Me").transform ;

		GameObject h = GameObject.Find ("Senpai Notice Me");
		HPSihir = h.GetComponent<Hpsih> ();

		hedgehog = gameObject.GetComponent<Animator> ();

		gameObject.collider.enabled = false;

		}
	
	// Update is called once per frame
	void Update () {

		Distancia = Vector3.Distance (Target.position, transform.position);

		if (Distancia < VistaDistancia) {

			hedgehog.SetBool("walkin", false);
			hedgehog.SetBool("idle", true);
			//renderer.material.color = Color.yellow;
			lookAt();
				}

		if (Distancia > VistaDistancia) {
			hedgehog.SetBool("idle", true);
			//renderer.material.color = Color.grey;
				}

		if (Distancia < AttackRange) {
			hedgehog.SetTrigger("attack");
			gameObject.collider.enabled = false;
			if(attacktime == false)
			{
			attacktime = true;
			gameObject.collider.enabled = true;
			StartCoroutine(Back());
				Debug.Log ("AttackTime se tornou true");
			}
			
			
				}


		else if (Distancia < ChaseRange) {
			//renderer.material.color = Color.red;
			hedgehog.SetBool("idle", false);
			hedgehog.SetBool("walkin", true);
			gameObject.collider.enabled = false;
			chase();
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

	IEnumerator Back()
	{
		yield return new WaitForSeconds (2);
		attacktime = false;
		Debug.Log ("Voltou a ficar false");
	}

	void OnTriggerEnter()
	{
		Debug.Log ("Damaged");
				
					HPSihir.Damaged = true;
					HPSihir.curHealth -= Damage;
				
	}



}

using UnityEngine;
using System.Collections;

public class FollowEnemy : MonoBehaviour {

	float Distancia;
	Transform Target;
	float VistaDistancia = 25.0f;
	float AttackRange = 10.0f;
	float MoveSpeed = 1.0f;
	float smoothing = 6.0f;

	void Start ()
	{
		Target = GameObject.Find ("Senpai Notice Me").transform ;
		}
	
	// Update is called once per frame
	void Update () {

		Distancia = Vector3.Distance (Target.position, transform.position);

		if (Distancia < VistaDistancia) {
			renderer.material.color = Color.yellow;
			lookAt();
				}

		if (Distancia > VistaDistancia) {
			renderer.material.color = Color.grey;
				}

		if (Distancia < AttackRange) {
			renderer.material.color = Color.red;
			attack();
				}

	 
	}

	void lookAt()
	{
		Quaternion rotation = Quaternion.LookRotation (Target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation,Time.deltaTime * smoothing);

	}


	void attack()
	{
		transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
	}



}

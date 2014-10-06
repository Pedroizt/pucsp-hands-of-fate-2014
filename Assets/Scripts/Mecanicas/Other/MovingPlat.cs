using UnityEngine;
using System.Collections;

public class MovingPlat : MonoBehaviour {


	public Transform respawn;
	public Vector3 dir;
	public float vel = 1;
	bool alive = true;


	void Start()
	{

		}
	


	void OnMouseDrag() //substituir por OnCollisionEnter
	{
		dir = transform.forward;
		transform.position += dir * vel;
		}


	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "parede") {
	
						Destroy (gameObject);
						Instantiate (gameObject, respawn.transform.position, respawn.transform.rotation);
				}



	}




}

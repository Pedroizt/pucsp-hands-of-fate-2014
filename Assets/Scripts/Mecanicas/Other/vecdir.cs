using UnityEngine;
using System.Collections;

public class vecdir : MonoBehaviour {

	public Vector3 direcao;
	public float dir;
	public float vel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		direcao=transform.forward;

		//transform.position += new Vector3 (0, 0, 1);
		//transform.position += direcao;
		vel = Input.GetAxis ("Vertical");
		dir = Input.GetAxis ("Horizontal");



		transform.position += direcao * vel;
		transform.Rotate (0, dir, 0);

		//transform.forward ira ir para frente de onde o cubo esta apontado
		//direcao esta armazenando o vector3
	
	}
}

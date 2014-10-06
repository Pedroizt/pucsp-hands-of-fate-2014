using UnityEngine;
using System.Collections;

public class Lighrang : MonoBehaviour {

	public Transform inicio;
	public Transform final;

	public float length;
	public float vel;

	bool volta = false;
	bool ativo = false;




	void Start()
	{

						
				
		}
	public float timed=0;
	void Update()
	{

		if (Input.GetKeyDown (KeyCode.F)) {
			ativo = true;

		}

		if (ativo) {



				
			timed+=Time.deltaTime;
		


			transform.position = Vector3.Lerp(inicio.position, final.position, Mathf.PingPong(timed,1));

			if(timed>2f){
				ativo=false;
				timed=0;
			}


				}
		


	}


     /*void VoltarLuz()
	{
		if (volta) {
			Debug.Log ("Acontece Algo");
			transform.position = Vector3.Lerp (final, inicio, Time.deltaTime * 2);
		}
	}*/



}

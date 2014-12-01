using UnityEngine;
using System.Collections;

public class CristalGrande : MonoBehaviour {


	//Esse script controla o cristal grande do inicio da primeira fase.
	GameObject[] Count; //Array que armazena objetos com a tag On.
	public bool Cutscene = false; //Bool que controla a cutscene.
	public GameObject cutscene;//Camera da cutscene.
	//private float duration = 1.0f;
	float vel = 0.5f; //velocidade que o cristal gira.




	// Use this for initialization
	public void Start () {


				//A camera da cutscene começa como false.
				//Caso o array tenha acumulado 4 objetos que possuem a tag on. O cristal e destruido e a camera
				//da cutscene e acionada.
				//LEMBRETE!: Esse metodo e chamado apenas uma vez, mas toda vez que uma CrystalSwitch foi acionada
				//Sendo assim, nao comprometendo a perfomance por tentar encontrar um objeto varias vezes.
		cutscene.SetActive (false);				

		Count = GameObject.FindGameObjectsWithTag ("On");
		if (Count.Length == 4) {
			Destroy (gameObject,1);
			Cutscene = true;
			cutscene.SetActive(true);
			Debug.Log ("Funcionou");
		}





	
	}

	void Update()
	{
		//Rotaçao do cristal.
		transform.Rotate (0, vel, 0);
	}



	




}

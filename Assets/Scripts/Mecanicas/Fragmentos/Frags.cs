using UnityEngine;
using System.Collections;

public class Frags : MonoBehaviour {


	//Script atrelado aos fragmentos da regiao. Quando o jogador passa por um deles, existe uma checagem de tags
	//Onde adiciona um nos seus fragmentos dependendo da tag do objeto que passou.
	private SeusFragmentos fragmentos;
	void Start()
	{
		GameObject f = GameObject.Find ("Frags");
		fragmentos = f.GetComponent<SeusFragmentos> ();
	}

	void OnTriggerEnter()
	{
		if (gameObject.tag == "SF") {
			fragmentos.SihFrags += 1;
			Destroy(gameObject);
				}

		if (gameObject.tag == "AF"){
			fragmentos.AurFrags += 1;
			Destroy(gameObject);
		}

		if (gameObject.tag == "HF"){
			fragmentos.HistFrags += 1;
			Destroy(gameObject);
		}

		if (gameObject.tag == "MF"){
			fragmentos.MythFrags += 1;
			Destroy(gameObject);
		}
	}
}

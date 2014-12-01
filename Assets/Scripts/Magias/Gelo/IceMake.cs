using UnityEngine;
using System.Collections;

public class IceMake : MonoBehaviour {


	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	 * FUNÇAO: Criar objetos que seriam utilizaveis no jogo, como uma esfera, uma ponte e um escudo.*/
	public Object IceSphere;
	public Object IceBridge;
	public Object IceShield;

	private SpellCast spellcast;
	// Use this for initialization
	void Start () {

		GameObject letitgo = GameObject.Find ("LongCast");
		spellcast = letitgo.GetComponent<SpellCast>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (spellcast.selo == "000") {
						Object obj = Instantiate (IceSphere, transform.position, transform.rotation);
						spellcast.selo = "";
						Destroy (obj, 3);
				} else if (spellcast.selo == "181") {
						Object obj = Instantiate (IceBridge, transform.position, transform.rotation);
						spellcast.selo = "";
						Destroy (obj, 3);
				}

		else if (spellcast.selo == "010") {
			Object obj = Instantiate (IceShield, transform.position, transform.rotation);
			spellcast.selo = "";
			Destroy (obj, 3);
		}




	
	}
}

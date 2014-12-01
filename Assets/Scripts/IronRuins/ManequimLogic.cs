using UnityEngine;
using System.Collections;

public class ManequimLogic : MonoBehaviour {

	/*SCRIPT NAO UTILIZADO.
	 * MOTIVO: SCRIPT DE SEGUNDA FASE. NAO IMPLEMENTADO.
	 * FUNÇAO: O puzzle consistia em coletar todas os pedaços de armadura de um manequim
	 * Ele estaria nu no começo, ao coletar as 4 e executar o comando, o manequim estaria
	 * com a armadura novamente e uma passagem para terceira fase aconteceria.*/
	public GameObject ManequimVazio;
	public GameObject ManequimCompleto;
	private Unlockeds un3;

	// Use this for initialization
	void Start () {

		ManequimCompleto.SetActive (false);

		GameObject u = GameObject.Find ("UnObj");
		un3 = u.GetComponent<Unlockeds> ();


	
	}
	
	void OnTriggerStay()
	{
		if (Input.GetKeyDown (KeyCode.F))
						checaritems ();
	}

	void checaritems()
	{
		if (un3.UnlockedHands == true && un3.UnlockedLegs == true 
						&& un3.UnlockedArmor == true && un3.UnlockedHelmet == true) {
						ManequimVazio.SetActive (false);
						ManequimCompleto.SetActive (true);


				} else
						return;

	}
}

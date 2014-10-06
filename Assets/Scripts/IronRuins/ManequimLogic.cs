using UnityEngine;
using System.Collections;

public class ManequimLogic : MonoBehaviour {

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

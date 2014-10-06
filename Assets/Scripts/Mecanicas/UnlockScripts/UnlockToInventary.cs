using UnityEngine;
using System.Collections;

public class UnlockToInventary : MonoBehaviour {


	private Unlockeds un;
	// Use this for initialization

	
	// Update is called once per frame
	void Start()
	{
		GameObject u = GameObject.Find ("UnObj");
		un = u.GetComponent<Unlockeds> ();
	}

	void OnTriggerEnter()
	{
		if (gameObject.tag == "Air") {
			Destroy (gameObject);
			un.UnlockedAir = true;
		}
		
		if (gameObject.tag == "BodyChange") {
			Destroy(gameObject);
			un.UnlockedBodyChange = true;
		}
		
		if (gameObject.tag == "Ice") {
			Destroy(gameObject);
			un.UnlockedIce = true;
		}
		
		if (gameObject.tag == "Fire") {
			Destroy(gameObject);
			un.UnlockedFire = true;
		}
		
		if (gameObject.tag == "Light") {
			Destroy(gameObject);
			un.UnlockedLight = true;
		}
		
		if (gameObject.tag == "Wood") {
			Destroy(gameObject);
			un.UnlockedWood = true;
		}
		
		if (gameObject.tag == "Earth") {
			Destroy(gameObject);
			un.UnlockedEarth = true;
		}
		
		if (gameObject.tag == "Water") {
			Destroy(gameObject);
			un.UnlockedWater = true;
		}
		
		if (gameObject.tag == "Void") {
			Destroy(gameObject);
			un.UnlockedVoid = true;
		}
		
		if (gameObject.tag == "TimeSpace") {
			Destroy(gameObject);
			un.UnlockedTimeSpace = true;
		}

		if (gameObject.tag == "armor") {
			Destroy(gameObject);
			un.UnlockedArmor = true;
				}

		if (gameObject.tag == "legs") {
			Destroy(gameObject);
			un.UnlockedLegs = true;
		}

		if (gameObject.tag == "hands") {
			Destroy(gameObject);
			un.UnlockedHands = true;
		}

		if (gameObject.tag == "helmet") {
			Destroy(gameObject);
			un.UnlockedHelmet = true;
		}

		if (gameObject.tag == "bananas") {
			Destroy(gameObject);
			un.UnlockedBotaBananas = true;
		}

}
}

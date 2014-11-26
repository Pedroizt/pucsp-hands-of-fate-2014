using UnityEngine;
using System.Collections;

public class Encolhimento : MonoBehaviour {

	public bool modificacorpo_locked = true;
	private bool duracao = false;
	bool parardecrescer = false;
	private GameObject longc;
	private Unlockeds un;



	private SpellCast spellcast1;
	// Use this for initialization
	void Start () {

		 longc = GameObject.Find ("SpellCast");
		spellcast1 = longc.GetComponent<SpellCast> ();

		GameObject u = GameObject.Find ("UnObj");
		un = u.GetComponent<Unlockeds> ();

	
	}
	
	// Update is called once per frame
	void Update () {

				

				if (spellcast1.selo == "131" || spellcast1.selo == "R L R") {
							if(un.UnlockedBodyChange == true && duracao == false){
						transform.localScale = new Vector3 (transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
			duracao = true;
			StartCoroutine (duracaoencolhimento());
						spellcast1.selo = "";
			}




				}

		if (spellcast1.selo == "131" && un.UnlockedBodyChange == false)
			spellcast1.selo = "";
		}

						
		IEnumerator duracaoencolhimento()
	{
		yield return new WaitForSeconds (3);
			duracao = false;

		if (duracao == false)
						spellcast1.selo = "";
			transform.localScale = new Vector3 (transform.localScale.x * 2f, transform.localScale.y * 2f, transform.localScale.z * 2f);

	}
}

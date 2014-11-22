using UnityEngine;
using System.Collections;

public class HedgehogHitbox : MonoBehaviour {

	private FollowEnemy fe;
	private Hpsih HPSihir;
	GameObject trs;

	// Use this for initialization
	void Start () {

		GameObject f = GameObject.Find ("bigcrush 1(Clone)/idle");
		fe = f.GetComponent<FollowEnemy> ();

		GameObject h = GameObject.Find ("Sihir");
		HPSihir = h.GetComponent<Hpsih> ();
		trs = GameObject.Find ("Sihir");


	
	}

	void OnTriggerEnter(Collider col)
	{
		if (fe.attacktime == false) {
			Debug.Log ("Damaged");
			
			HPSihir.Damaged = true;
			HPSihir.curHealth -= fe.Damage;
			trs.SendMessage ("Damage", SendMessageOptions.DontRequireReceiver);

				}

		if (col.gameObject.tag == "Player")
						Debug.Log ("Colidindo");

	}

}

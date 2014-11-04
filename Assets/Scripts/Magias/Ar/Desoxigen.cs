using UnityEngine;
using System.Collections;

public class Desoxigen : MonoBehaviour {

	//public Object desoxig;
	private SpellCast castspell;
	private Hpsih hp;
	Transform target;
	GameObject DesoxField;
	bool alive = false;
	GameObject teste;
	int scalerate;
	public float damage = 0.5f;








	void Start()
	{
		GameObject s = GameObject.Find ("SpellCast");
		castspell = s.GetComponent<SpellCast> ();
		target = GameObject.Find ("Senpai Notice Me/SpellCast").transform;
		DesoxField = GameObject.Find ("desoxfield");
		GameObject h = GameObject.Find ("Senpai Notice Me");
		hp = h.GetComponent<Hpsih> ();




	}
	void Update()
	{
	 
		float a;
		bool ativo = false;



		if (castspell.selo == "01") {


			GameObject obj = Instantiate (DesoxField, target.position, target.rotation) as GameObject;
			obj.rigidbody.AddForce(target.forward * 50);
			castspell.selo = "";
			hp.curHealth -= hp.maxHealth/8;

			Destroy(obj, 3);

		}


		
	}

	void OnTriggerEnter(Collider Col)
	{

		if (Col.gameObject.tag == "Fire") {
			//Debug.Log("Esta Colidindo");
			Destroy(Col.gameObject);
				}

		if (Col.gameObject.tag == "Enemy") {
			Debug.Log ("Colliding");
			Col.gameObject.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
		}
	}









	// Use this for initialization
	/*void Start () {
		GameObject longcast = GameObject.Find ("LongCast");
		spellcast = longcast.GetComponent<SpellCast> ();



	
	}
	
	// Update is called once per frame
	void Update () {

						if (spellcast.selo == "01" && duracao == false) {


						Object obj = Instantiate (desoxig, transform.position, transform.rotation);
						duracao = true;
						StartCoroutine (ativo (obj));

						spellcast.selo = "";
						Destroy (obj, tempodeespera);

				} else if (spellcast.selo == "01" && duracao == true)
						spellcast.selo = "";
				}




						
				


	IEnumerator ativo(Object ob)
	{

						
		yield return new WaitForSeconds (tempodeespera);
		duracao = false;
				
				
	}*/



}

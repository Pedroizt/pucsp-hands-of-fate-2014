using UnityEngine;
using System.Collections;

public class WindSwitch : MonoBehaviour {


	//private Hovering winds;
	public GameObject cameracutscene;
	public bool switchon = false;
	public GameObject target;
	bool once = false;



	void Start()
	{
		cameracutscene.SetActive (false);
		target.gameObject.SetActive (false);
	}

	void OnTriggerEnter (Collider col)
	{



			if (col.gameObject.tag == "esferar" && once == false) {
						target.gameObject.SetActive (true);
						switchon = true;
						once = true;
						
				}
				
	}

	void Update()
	{

		if (switchon)
						StartCoroutine (cutscene ());

	}

	IEnumerator cutscene()
	{
		cameracutscene.SetActive (true);
		yield return new WaitForSeconds(2);
		{
			cameracutscene.SetActive (false);
			switchon = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class WindSwitch : MonoBehaviour {


	//private Hovering winds;
	public bool switchon = false;
	public GameObject target;
	public AudioSource audio1;


	void Start()
	{

		target.gameObject.SetActive (false);
	}

	void OnTriggerEnter (Collider col)
	{



			if (col.gameObject.tag == "esferar") {
						target.gameObject.SetActive (true);
						audio1.Play();
				}
				
	}

	void Update()
	{
		if (switchon)
			target.gameObject.SetActive (true);
	}
}

using UnityEngine;
using System.Collections;

public class CameraCutscene : MonoBehaviour {

	private CristalGrande cgrande;
	// Use this for initialization
	void Start () {


		GameObject c = GameObject.Find ("CristalGrande");
		cgrande = c.GetComponent<CristalGrande> ();

	
	}
	
	// Update is called once per frame
	void Update () {



		if (cgrande.Cutscene == true) {
						
			//Debug.Log("SendMessage");

			            StartCoroutine(voltabool());
				}


	
	}

	IEnumerator voltabool()
	{

		yield return new WaitForSeconds(3);
		{
			   			//Debug.Log ("FuncionaChan");
					
						gameObject.SetActive(false);
						
				}
		}
}

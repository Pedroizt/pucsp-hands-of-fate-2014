using UnityEngine;
using System.Collections;

public class CutsceneControl : MonoBehaviour {


	int ctimer = 2;
	float damping = 1;
	public GameObject S1;
	public GameObject S2;
	public GameObject S3;
	public GameObject S4;
	public GameObject Text;
	private Fade fader;
	bool once = false;
	bool once2 = false;
	bool once3 = false;
	bool once4 = false;


	// Use this for initialization
	void Start () {

		GameObject f = GameObject.Find ("screenFader");
		fader = f.GetComponent<Fade> ();

		S1.SetActive (true);
		S2.SetActive (false);
		S3.SetActive (false);
		S4.SetActive (false);




	
	}
	
	// Update is called once per frame
	void LateUpdate () {


		Destroy (S1, ctimer);
		if (S1 == null && once == false ) {
						once = true;
						S2.SetActive (true);
			Destroy(S2, ctimer );
						
				}

		if (S2 == null && once2 == false) {
			once2 = true;
			S3.SetActive (true);
			Destroy(S3, ctimer);
				}

		if (S3 == null && once3 == false) {
			once3 = true;
			S4.SetActive (true);
			Destroy(S4, ctimer);
		}

		if (S4 == null && once4 == false) {
			once = true;
			Text.SetActive(false);

				}








}


}

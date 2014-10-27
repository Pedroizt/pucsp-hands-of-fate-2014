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
	private HistoriaControl history;
	bool once = false;
	bool OnceLate = false;
	bool once2 = false;
	bool once3 = false;
	bool once4 = false;
	public bool jogoinicia = false;


	// Use this for initialization
	void Start () {

		GameObject h = GameObject.Find ("OpeningHistory");
		history = h.GetComponent<HistoriaControl> ();


		Text.SetActive (false);
		S1.SetActive (true);
		S1.GetComponent<Animator> ().enabled = false;
		S2.SetActive (false);
		S3.SetActive (false);
		S4.SetActive (false);

		if (history.começacutscene == true)
						S1.GetComponent<Animator> ().enabled = true;






	
	}
	
	// Update is called once per frame
	void LateUpdate () {



		if (history.começacutscene == true && OnceLate == false) {
			Start();
			OnceLate = true;
				}

		if (history.começacutscene == true) {

			Text.SetActive(true);
						Destroy (S1, ctimer);
						if (S1 == null && once == false) {
								once = true;

								S2.SetActive (true);
								Destroy (S2, ctimer);
						
						}

						if (S2 == null && once2 == false) {
								once2 = true;
								S3.SetActive (true);
								Destroy (S3, ctimer);
						}

						if (S3 == null && once3 == false) {
								once3 = true;
								S4.SetActive (true);
								Destroy (S4, ctimer);
						}

						if (S4 == null && once4 == false) {
								once = true;
								Text.SetActive (false);
				jogoinicia = true;

						}
				}








}


}

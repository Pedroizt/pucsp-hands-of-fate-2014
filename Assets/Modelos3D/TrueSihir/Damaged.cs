using UnityEngine;
using System.Collections;

public class Damaged : MonoBehaviour
{

		Color colorstart = Color.white;
		Color colorend = Color.red;
		float duracao = 1.0f;
		private TrueSihir sihir;

		// Use this for initialization
		void Start ()
		{

				GameObject s = GameObject.Find ("Sihir");
				sihir = s.GetComponent<TrueSihir> ();
	
		}
	
		// Update is called once per frame
	public float timed = 0;
		void Update ()
		{
				
				if (sihir.damaged == true) {
						timed += Time.deltaTime;
						float lerp = Mathf.PingPong (timed, 0.4f);
						renderer.material.color = Color.Lerp (colorstart, colorend, lerp);
						if (timed>0.8f ) {
								sihir.damaged = false;
								timed = 0f;
								Debug.Log ("Teste");
						}
				}

				if (sihir.damaged == false) {
						renderer.material.color = Color.white;
				}
	
		}


}

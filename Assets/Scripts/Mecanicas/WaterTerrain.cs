using UnityEngine;
using System.Collections;

public class WaterTerrain : MonoBehaviour {

	private Hpsih health;
	private MotionBlur mb;
	private bool InsideWater = false;

	void Start()
	{
		GameObject h = GameObject.Find ("Sihir");
		health = h.GetComponent<Hpsih> ();

		GameObject m = GameObject.Find ("RealCamera");
		mb = m.GetComponent<MotionBlur> ();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Funciona");
						InsideWater = true;
				}
	}

	void OnTriggerExit()
	{
		InsideWater = false;
		Debug.Log ("Sim");
	}

	void Update()
	{
		if (InsideWater == true) {
			health.curHealth -= health.maxHealth / 4 * Time.deltaTime;
			mb.blurAmount += 0.3f * Time.deltaTime;
				}
		if (InsideWater == false) {
			//Debug.Log("Teste");
						mb.blurAmount -= 0.1f * Time.deltaTime;
				}
	}
}

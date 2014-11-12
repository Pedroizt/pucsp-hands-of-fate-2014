using UnityEngine;
using System.Collections;

public class Minimapafollow : MonoBehaviour {


	public GameObject Target;
	float zi;

	// Use this for initialization
	void Start () {

		gameObject.camera.pixelRect = new Rect(Screen.width - 170, Screen.height - 170, 140, 140);
	
	}
	
	// Update is called once per frame
	void Update () {


		gameObject.transform.position = Target.transform.position;
	
	}
}

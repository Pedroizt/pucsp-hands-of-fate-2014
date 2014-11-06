using UnityEngine;
using System.Collections;

public class Minimapafollow : MonoBehaviour {


	public GameObject Target;
	float zi;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {


		gameObject.transform.position = Target.transform.position;
	
	}
}

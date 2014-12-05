using UnityEngine;
using System.Collections;

public class IABeh : MonoBehaviour {
	/*public GameObject cerebro;
	public Animator anim;
	public NavMeshAgent agent;
	private score sc;
	// Use this for initialization
	void Start () {
		AddTagRecursively (transform,"Enemy");
		GameObject s = GameObject.Find ("score");
		sc = s.GetComponent<score> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (cerebro != null) {
			if(agent.enabled){
				anim.SetBool("FF",true);
				agent.SetDestination(cerebro.transform.position);
			}
			//float angle=Vector3.Angle(transform.right,transform.position-cerebro.transform.position);

			//transform.Rotate(Vector3.up,angle-90);

			//transform.Translate(Vector3.forward*Time.deltaTime*5,Space.Self);

				}
	}
	public void Atingido () {
		anim.enabled = false;
		//Destroy (agent);
		agent.enabled = false;
		//Destroy (this);
		AddTagRecursively (transform,"Untagged");
		sc.numbers += 100;
		Invoke ("RemoveColliderRecursively", 10);
		Invoke ("Destroybody", 11);
		}
	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag.Equals ("Player")) {
			cerebro=col.gameObject;
			audio.pitch=Random.Range(0.6f,1.6f);
			audio.Play();

		}


	}
	void AddTagRecursively(Transform trans, string tag)
	{
		trans.gameObject.tag = tag;
		if(trans.childCount > 0)
			foreach(Transform t in trans)
				AddTagRecursively(t, tag);
	}
	void RemoveColliderRecursively(){
			RemoveColliderRecursively (transform);
		}
	void RemoveColliderRecursively(Transform trans)
	{
		if(trans.gameObject.collider)
		trans.gameObject.collider.enabled = false;

		if(trans.childCount > 0)
			foreach(Transform t in trans)
				RemoveColliderRecursively(t);
	}

	void Destroybody(){

		Destroy (gameObject);
	}*/
}

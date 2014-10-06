using UnityEngine;
using System.Collections;

public  class BreakingBlocks : MonoBehaviour {

	private VariaveisBloco breaking;

	void Awake()
	{				
		GameObject b = GameObject.Find ("VariavelBloco");
		breaking = b.GetComponent<VariaveisBloco> ();
	}




	void Update()
	{



			
			if (breaking.noplatform == false) {
						breaking.respawn = (Transform)Instantiate (breaking.platforms, 
			                                  transform.position, transform.rotation);
		
						breaking.respawn.parent = transform;



			

				
						breaking.noplatform = true;
						
				}
			

			

	
			
				

		if (breaking.respawn == null) {
			breaking.platformdestroyed = true;
			Debug.Log ("Destruido");
			StartCoroutine (reinstantiate ());


		}
	}
		

	IEnumerator reinstantiate()
	{
		yield return new WaitForSeconds (2);
		{
			if (breaking.platformdestroyed){
			breaking.respawn = (Transform)Instantiate(breaking.platforms, 
				                                          transform.position,transform.rotation);
				Debug.Log ("Reconstruida");
			breaking.respawn.parent = transform;
			breaking.platformdestroyed = false;
			}
				}
	}
}








using UnityEngine;
using System.Collections;

public class TriggerSendMessage : MonoBehaviour {

	public GameObject mapcamera;
	void OnTriggerEnter()
	{
		if (gameObject.tag == "Iron")
			mapcamera.SendMessage ("DonDrawCloud1", SendMessageOptions.DontRequireReceiver);
		if (gameObject.tag == "Forest")
			mapcamera.SendMessage ("DonDrawCloud2", SendMessageOptions.DontRequireReceiver);
		if (gameObject.tag == "Temple")
			mapcamera.SendMessage ("DonDrawCloud3", SendMessageOptions.DontRequireReceiver);
		if (gameObject.tag == "Mountain")
			mapcamera.SendMessage ("DonDrawCloud4", SendMessageOptions.DontRequireReceiver);

	}

}

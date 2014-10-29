using UnityEngine;
using System.Collections;

public class GameTime : MonoBehaviour {
	public Transform[] sun;
	public float dayCycleInMinutes = 1;
	private const float second = 1;
	private const float minute = 60*second;
	private const float hour = 60*minute;
	private const float day = 24*hour;
	private const float degreespersecond = 360/day;
	private float degreesrotation;
	private float timeofday;


	// Use this for initialization
	void Start () {
		timeofday = 0;
		degreesrotation = degreespersecond * day / (dayCycleInMinutes * minute);

	
	}
	
	// Update is called once per frame
	void Update () {
		for (int cnt = 0; cnt < sun.Length; cnt++) {
						sun [cnt].Rotate (new Vector3 (degreesrotation, 0, 0) * Time.deltaTime);
				}
		timeofday += Time.deltaTime;
		Debug.Log (timeofday);
	
	}
}

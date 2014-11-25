using UnityEngine;
using System.Collections;

public class Xbox360_Controls : MonoBehaviour 
{
	// These are used to modify the player movement speed, and rotation speed.
	//public float PlayerMovementSpeed = 30;
	//public float PlayerRotationSpeed = 180;
	public SpellCast_Xbox Controller1;
	public SpellCast Controller2;
	public string PressedButton;


	void Start ()
	{

		GameObject s = GameObject.Find ("SpellCast_Xbox");
		Controller1 = s.GetComponent <SpellCast_Xbox> ();
		GameObject c = GameObject.Find ("SpellCast");
		Controller2 = c.GetComponent <SpellCast> ();


	}
	

	void Update ()
	{
		//Movement();
		UserInputs();

	}
	

	/*void Movement()
	{
		// This line is for vertical movement, right now its on the Z AXIS.
		transform.Translate(0,0,Input.GetAxis("Vertical") * Time.deltaTime * PlayerMovementSpeed);
		
		// This line is for horizontal movement, right now its on the X AXIS. When combined with vertical movement it can be used for Strafing.
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * PlayerMovementSpeed,0,0);
		
		// This line is for rotation, right now its on the Y AXIS. 
		transform.Rotate(0,Input.GetAxis("RightStick") * Time.deltaTime * PlayerRotationSpeed,0);
	}
	*/




	void UserInputs()
	{
		// A Button is read from Input Positive Button "joystick button 0"
		if(Input.GetButtonDown ("360_AButton"))
		{

			Debug.Log("A Button!");
			PressedButton = "A";
		}
		
		// B Button is read from Input Positive Button "joystick button 1"
		if(Input.GetButtonDown ("360_BButton"))
		{
			Debug.Log("B Button!");
			PressedButton = "B";
		}
		
		// X Button is read from Input Positive Button "joystick button 2"
		if(Input.GetButtonDown ("360_XButton"))
		{
			Controller2.FinishMagic();
			Debug.Log("X Button!");
			PressedButton = "X";
		}
		
		// Y Button is read from Input Positive Button "joystick button 3"
		if(Input.GetButtonDown ("360_YButton"))
		{

			Debug.Log("Y Button!");
			PressedButton = "Y";
		}
				
		// Left Bumper is read from Input Positive Button "joystick button 4"
		if(Input.GetButtonDown ("360_LeftBumper"))
		{
			Debug.Log("Left Bumper!");
			PressedButton = "LeftBumper";
		}
		
		// Right Bumper is read from Input Positive Button "joystick button 5"
		if(Input.GetButtonDown ("360_RightBumper"))
		{
			Debug.Log("Right Bumper!");
			PressedButton = "RightBumper";
		}
		
		// Back Button is read from Input Positive Button "joystick button 6"
		if(Input.GetButtonDown ("360_BackButton"))
		{
			Debug.Log("Back Button!");
			PressedButton = "BackButton";
		}
		
		// Start Button is read from Input Positive Button "joystick button 7"
		if(Input.GetButtonDown ("360_StartButton"))
		{
			Debug.Log("Start Button!");
			PressedButton = "StartButton";
		}
		
		// Left Thumbstick Button is read from Input Positive Button "joystick button 8"
		if(Input.GetButtonDown ("360_LeftThumbstickButton"))
		{
			Debug.Log("Left Thumbstick Button!");
		}
		
		// Right Thumbstick Button is read from Input Positive Button "joystick button 9"
		if(Input.GetButtonDown ("360_RightThumbstickButton"))
		{
			Debug.Log("Right Thumbstick Button!");
		}
		

		// Right Trigger is activated when pressure is above 0, or the dead zone.
		/*if(Input.GetAxis("360_Triggers")>0.001)
		{
			Debug.Log ("Right Trigger!");
		}
		
		// Right Trigger is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_Triggers")<0)
		{
			Debug.Log("Left Trigger!");
		}*/
		
		// The D-PAD is read from the 6th(Horizontal) and 7th(Vertical) Joystick Axes and read from a Sensitivity rating from -1 to 1, similar to the Triggers.
		//
		// Right D-PAD Button is activated when pressure is above 0, or the dead zone.
		if(Input.GetAxis("360_HorizontalDPAD")>0.001)
		{
			Debug.Log ("Right D-PAD Button!");
		}
		
		// Left D-PAD Button is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_HorizontalDPAD")<0)
		{
			Debug.Log("Left D-PAD Button!");
		}
		
		// Up D-PAD Button is activated when pressure is above 0, or the dead zone.
		if(Input.GetAxis("360_VerticalDPAD")>0.001)
		{
			Controller1.UDpad ();
			Debug.Log ("Up D-PAD Button!");
		}
		
		// Down D-PAD Button is activated when pressure is under 0, or the dead zone.
		if(Input.GetAxis("360_VerticalDPAD")<0)
		{
			Controller1.DDpad ();
			Debug.Log ("Down D-PAD Button!");
		}
	}

	public void NullButton ()
	{

		PressedButton = "Null";

	}
}
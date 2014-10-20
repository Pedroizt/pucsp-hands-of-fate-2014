﻿using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour
{
	public float fadeSpeed = 5f;          // Speed that the screen fades to and from black.
	public bool sceneStarting = true;
	public bool gameOver = false;
	private Hpsih hp;
	private CutsceneControl cc;
	
	//private bool sceneStarting = true;      // Whether or not the scene is still fading in.
	
	
	public void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(-1000, -1000, 5000, 5000);

		GameObject g = GameObject.Find ("Senpai Notice Me");
		hp = g.GetComponent<Hpsih> ();

		GameObject c = GameObject.Find ("Opening Cutscene");
		cc = c.GetComponent<CutsceneControl> ();
	}
	
	
	void Update ()
	{
		// If the scene is starting...
		if(sceneStarting)
			// ... call the StartScene function.
			StartScene();

		if (gameOver == true)
						EndScene ();
	}
	
	
	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
	}
	
	
	void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(guiTexture.color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			
			// The scene is no longer starting.
			sceneStarting = false;
		}
	}
	
	
	public void EndScene ()
	{

		Debug.Log ("Aparentemente, isso funciona");

						// Make sure the texture is enabled.
						guiTexture.enabled = true;
		
						// Start fading towards black.
						
						
						FadeToBlack ();
						
				


						
		
						// If the screen is almost black...
						if (gameOver == true && guiTexture.color.a >= 0.95f)
			// ... reload the level.
								Application.LoadLevel (3);

			
				
	}
}
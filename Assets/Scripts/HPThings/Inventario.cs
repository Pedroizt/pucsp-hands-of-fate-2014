using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	public bool isPause = false;
	public LayerMask Invent;
	public LayerMask Everything;
	//public Camera MainCamera;

	//private MagicTextures mt;
	public float width1;
	public float heigth1;
	private UnlockToInventary unlc;
	private Unlockeds un2;
	private FragsOnInventory fr;
	private Hpsih hp;
	public GameObject Air;
	public GameObject BC;
	public GameObject Ice;
	public GameObject Fire;
	public GameObject light;
	public GameObject Wood;
	public GameObject Earth;
	public GameObject Water;
	public GameObject Void;
	public GameObject TimeSpace;
	/*public GameObject armor;
	public GameObject luva;
	public GameObject legs;
	public GameObject helmet;
	public GameObject bota_banana;*/




	void Awake()
	{
		//guiTexture.enabled = false;
		//guiTexture.pixelInset = new Rect (-410, -283, 824, 568);

		Debug.Log ("FuncionaChan");
		gameObject.renderer.enabled = false;

		//GameObject g = GameObject.Find ("Senpai Notice Me");
		//hp = g.GetComponent<Hpsih> ();



		//GameObject t = GameObject.Find ("MagicTextures");
		//mt = t.GetComponent<MagicTextures> ();

		GameObject p = GameObject.Find ("Magic");
		unlc = p.GetComponent<UnlockToInventary> ();

		GameObject u2 = GameObject.Find ("UnObj");
		un2 = u2.GetComponent<Unlockeds> ();

		Air.SetActive (false);
		BC.SetActive (false);
		Ice.SetActive (false);
		Fire.SetActive (false);
		light.SetActive (false);
		Wood.SetActive (false);
		Earth.SetActive (false);
		Water.SetActive (false);
		Void.SetActive (false);
		TimeSpace.SetActive (false);
		/*armor.SetActive (false);
		legs.SetActive (false);
		luva.SetActive (false);
		bota_banana.SetActive (false);
		helmet.SetActive (false);*/




	}
	// Update is called once per frame
	void Update () {

				if (Input.GetKeyDown (KeyCode.I)) {

						isPause = !isPause;
						if (isPause) {
				Air.SetActive(true);
								Time.timeScale = 0;
								//DrawInventario();
								DrawSkills ();
								//DrawItems();
								gameObject.renderer.enabled = true;
								//hp.paused = true;

						} else {
								Time.timeScale = 1;
								//MainCamera.cullingMask = Everything;
								//guiTexture.enabled = false;
								gameObject.renderer.enabled = false;
								//hp.paused = false;
								DontDraw ();

						}
	
				}
		}

	/*void DrawInventario()
	{
		Debug.Log ("Funciona");
		MainCamera.cullingMask = Invent;
		guiTexture.enabled = true;
	}*/

	void DontDraw()
	{
			Air.SetActive(false);
			BC.SetActive (false);
			Ice.SetActive (false);
			Fire.SetActive (false);
			light.SetActive (false);
			Wood.SetActive (false);
			Earth.SetActive (false);
			Water.SetActive (false);
			Void.SetActive (false);
			TimeSpace.SetActive (false);
			/*armor.SetActive (false);
			legs.SetActive (false);
			luva.SetActive (false);
			bota_banana.SetActive (false);
			helmet.SetActive (false);*/
		
	}

	void DrawItems()
	{



		}

	void DrawSkills()
	{
		
		if (isPause && un2.UnlockedAir == true){
			//GUI.DrawTexture (new Rect(Screen.width - 368, Screen.height - 502, 75, 75), mt.AirMagic);
			Air.SetActive(true);


		}
		
		if (isPause && un2.UnlockedBodyChange == true){
				BC.SetActive (true);
			//GUI.DrawTexture (new Rect(Screen.width - 311, Screen.height - 430, 75, 75), mt.BodyChangeMagic);
		}
		
		if (isPause && un2.UnlockedIce == true)
		{
				Ice.SetActive (true);
			//GUI.DrawTexture (new Rect(Screen.width - 226, Screen.height - 354, 75, 75), mt.IceMagic);
		}
		
		if (isPause && un2.UnlockedFire == true)
		{
				Fire.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 311, Screen.height - 283, 75, 75), mt.FireMagic);
		}
		
		if (isPause && un2.UnlockedLight == true)
		{
				light.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 365, Screen.height - 206, 75, 75), mt.LightMagic);
		}
		
		if (isPause && un2.UnlockedWood == true)
		{
				Wood.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 483, Screen.height - 206, 75, 75), mt.WoodMagic);
		}
		
		if (isPause && un2.UnlockedEarth == true)
		{
				Earth.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 540, Screen.height - 283, 75, 75), mt.EarthTexture);
		}
		
		if (isPause && un2.UnlockedWater == true)
		{
				Water.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 630, Screen.height - 354, 75, 75), mt.WaterMagic);
		}
		
		if (isPause && un2.UnlockedVoid == true)
		{
				Void.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 540, Screen.height - 430, 75, 75), mt.VoidTexture);
		}
		
		if (isPause && un2.UnlockedTimeSpace == true)
		{
				TimeSpace.SetActive(true);
			//GUI.DrawTexture (new Rect(Screen.width - 483, Screen.height - 502, 75, 75), mt.TimeSpace);
		}

		/*if (isPause && un2.UnlockedArmor == true)
		{
			armor.SetActive(true);

		}

		if (isPause && un2.UnlockedHands == true)
		{
			luva.SetActive(true);
			
		}

		if (isPause && un2.UnlockedLegs == true)
		{
			legs.SetActive(true);
			
		}

		if (isPause && un2.UnlockedHelmet == true)
		{
			helmet.SetActive(true);
			
		}

		if (isPause && un2.UnlockedBotaBananas == true)
		{
			bota_banana.SetActive(true);
			
		}*/
		
		
	}


}

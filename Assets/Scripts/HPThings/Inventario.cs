using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {

	//Esse script se trata do inventario do jogo;
	GameObject Pause; //Nao utilizado, usaria um gameobject que teria a funçao de pause.
	GameObject RealCamera; //Camera do jogo.
	public bool isPause = false; //Controle de pause do jogo

	//As variaveis abaixo nao foram utilizadas.
	public LayerMask Invent;
	public LayerMask Everything;
	//public Camera MainCamera;

	public GameObject camerainvent; //Camera exclusiva do inventario.
	//private MagicTextures mt;
	public float width1; //Teste para largura do inventario.
	public float heigth1; //Teste para altura do inventario.
	//As variaveis a seguir, sao utilizadas para conseguir componentes de outros script
	private UnlockToInventary unlc;
	private Unlockeds un2;
	private FragsOnInventory fr;
	private Hpsih hp;
	//As variaveis a seguir sao os icones de feitiços do inventario.
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
	float cm;//nao utilizado.
	//Variaveis usadas para mudar o cursor.
	public Texture2D cursorTexture; 
	CursorMode cursormode = CursorMode.Auto;
	Vector2 hotspot = Vector2.zero;
	//Outras partes do inventario
	public GameObject menuhistoria;
	public GameObject menuopcoes;
	public GameObject menusalvar;
	public bool isinvent = false; //nao utilizado, saber se o inventario esta ligado.
	private mapa map;//checar o mapa
	private CutsceneControl opening;//checar para saber se a cutscene inicial ja aconteceu.

	
	/*public GameObject armor;
	public GameObject luva;
	public GameObject legs;
	public GameObject helmet;
	public GameObject bota_banana;*/




	void Awake()
	{
		//guiTexture.enabled = false;
		//guiTexture.pixelInset = new Rect (-410, -283, 824, 568);

		//Mouse e inventario desabilitado.
		Screen.showCursor = false;
		gameObject.renderer.enabled = false;
		menuhistoria.renderer.enabled = false;
		menuopcoes.renderer.enabled = false;
		menusalvar.renderer.enabled = false;

		//GameObject g = GameObject.Find ("Sihir");
		//hp = g.GetComponent<Hpsih> ();



		//GameObject t = GameObject.Find ("MagicTextures");
		//mt = t.GetComponent<MagicTextures> ();

		//Os gameobjects a seguir sao inicializados para conseguir componentes de outros scripts utilizando
		//as variaveis ja declaradas.
		GameObject p = GameObject.Find ("Magic");
		unlc = p.GetComponent<UnlockToInventary> ();

		GameObject u2 = GameObject.Find ("UnObj");
		un2 = u2.GetComponent<Unlockeds> ();

		RealCamera = GameObject.Find ("RealCamera");
		Pause = GameObject.Find ("Pause");

		GameObject m = GameObject.Find ("MapCamera");
		map = m.GetComponent<mapa> ();

		GameObject c = GameObject.Find ("Opening Cutscene");
		opening = c.GetComponent<CutsceneControl> ();

		//Icones dos feitiços desabilitados.
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

				
		//Caso ja esteja fora da cutscene do jogo e que o mapa nao esta habilitado.
		//E o botao do inventario foi pressionado (No caso START ou I).
		if (Input.GetButtonDown("Inventario") && map.ismap == false && opening.jogoinicia == true) {
						pause ();//metodo para trocar a bool de pause, controlando o inventario.
			
						if (isPause || map.ismap) {
				
				
								//Para o tempo do jogo, pausando-o, habilitando todo inventario.
								Time.timeScale = 0;
								Air.SetActive (true);
								RealCamera.SendMessage ("MouseDisabled");
				
				
				
				
								//DrawInventario();
								DrawSkills ();
								//DrawItems();
								gameObject.renderer.enabled = true;
								menuhistoria.renderer.enabled = true;
								menuhistoria.SetActive (true);
								menuopcoes.renderer.enabled = true;
								menuopcoes.SetActive (true);
								menusalvar.renderer.enabled = true;
								menusalvar.SetActive (true);
								map.isinventario = true;
				
						}
				
								//hp.paused = true;
				
				
						else {
								//Volta o tempo ao normal e desabilita tudo que o inventario tem.
								Time.timeScale = 1;
								//MainCamera.cullingMask = Everything;
								//guiTexture.enabled = false;
								gameObject.renderer.enabled = false;
								menuhistoria.SetActive (false);
								menuopcoes.SetActive (false);
								menusalvar.SetActive (false);
								menuhistoria.renderer.enabled = false;
								menuopcoes.renderer.enabled = false;
								menusalvar.renderer.enabled = false;
								//hp.paused = false;
								DontDraw ();
								RealCamera.SendMessage ("MouseEnabled");
								map.isinventario = false;
				
						}
			

				}
			
			
			
			
			
			
						//Caso o jogador tenha usado setas do teclado para mover o inventario.
						if (Input.GetKeyDown (KeyCode.RightArrow) && isPause) {
								camerainvent.transform.Rotate (0, 90, 0);
				
						}
						if (Input.GetKeyDown (KeyCode.LeftArrow) && isPause) {
								camerainvent.transform.Rotate (0, -90, 0);
						}
						//Habilita o cursor do mosue.
						if (isPause) {
								Screen.showCursor = true;
								Cursor.SetCursor (cursorTexture, hotspot, cursormode);
						}
			
						if (!isPause) {
								Screen.showCursor = false;
								Cursor.SetCursor (cursorTexture, hotspot, cursormode);
						}
			
		}

	/*void DrawInventario()
	{
		Debug.Log ("Funciona");
		MainCamera.cullingMask = Invent;
		guiTexture.enabled = true;
	}*/

	void DontDraw() //Desabilita todos os icones de feitiços quando o inventario nao esta ligado.
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

	void pause()//Metodo de controle de inventario, a bool e trocada ao usar o comando de inventario.
	{
		isPause = !isPause;
	}

	void DrawItems()//Nao utilizado, ia exibir itens.
	{



		}

	void DrawSkills() //Controle, caso algum feitiço fosse habilitado
		//A vida da personagem seria desabilitada e o icone de feitiço seria habilitado propriamente.
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

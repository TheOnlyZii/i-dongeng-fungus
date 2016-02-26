using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stickerManager : MonoBehaviour {

	public Rigidbody2D[] sticker;
	public GameObject saveHolder;
	public GameObject loadingScreen;
	public int levelToLoad;
	public int[] stickerToggle;
	public GameObject[] stickerButton;

	public bool deleteFlag;
	public static bool toMainMenu = false;
	
	SaveScript saveControl;

	// Use this for initialization
	void Start () {
		saveControl = saveHolder.GetComponent<SaveScript> ();
		Debug.Log (Application.loadedLevel);
		Debug.Log (Application.loadedLevelName);

		if (Application.loadedLevel == 1 && mainMenuUI.loadFlag1 == true) {
			saveControl.LoadCurrentScene();
			mainMenuUI.loadFlag1 = false;
		}

		if (Application.loadedLevel == 4 && mainMenuUI.loadFlag2 == true) {
			saveControl.LoadCurrentScene();
			mainMenuUI.loadFlag2 = false;
		}

		if (Application.loadedLevel == 5 && mainMenuUI.loadFlag3 == true) {
			saveControl.LoadCurrentScene();
			mainMenuUI.loadFlag3 = false;
		}

		if (Application.loadedLevel == 6 && mainMenuUI.loadFlag4 == true) {
			saveControl.LoadCurrentScene();
			mainMenuUI.loadFlag4 = false;
		}
		if (Application.loadedLevel == 7 && mainMenuUI.loadFlag5 == true) {
			saveControl.LoadCurrentScene();
			mainMenuUI.loadFlag5 = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
//		ClickRay ();

		stickerToggle [0] = PlayerPrefs.GetInt ("sticker1-1");
		stickerToggle [1] = PlayerPrefs.GetInt ("sticker1-2");

		if(stickerToggle [0] == 1)
			stickerButton[0].GetComponent<Button>().interactable = true;
		else
			stickerButton[0].GetComponent<Button>().interactable = false;

		if(stickerToggle [1] == 1)
			stickerButton[1].GetComponent<Button>().interactable = true;
		else
			stickerButton[1].GetComponent<Button>().interactable = false;

	}

//	public void OnLevelWasLoaded(int level)
//	{
//		if(level == 1)
//		{
//			Debug.Log("template 1 loaded");
//		}
//
//		if(level == 1 && mainMenuUI.loadFlag1 == true)
//		{
//			Debug.Log("load start");
//			mainMenuUI.loadFlag1 = false;
//			saveControl.LoadCurrentScene();
//		}
//	}

	IEnumerator DisplayLoadingScreen(int level)
	{
		loadingScreen.SetActive (true);
		
		AsyncOperation async =  Application.LoadLevelAsync (level);
		
		while (async.isDone)
			levelToLoad = 0;
		yield return null;
	}

//	public void ClickRay()
//	{
//		if (Input.GetMouseButtonDown (0)) {
//			RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);
//
//			if(hit.collider.tag == "sticker")
//			{
//				Debug.Log("hit sticker");
//				hit.collider.gameObject.GetComponent<stickerController>().selected = true;
//			}
//
//			if(hit.collider.tag != "sticker")
//			{
//				Debug.Log("does not hit sticker");
//				hit.collider.gameObject.GetComponent<stickerController>().selected = true;
//			}
//		}
//	}

	public void stickerButton1()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[0], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker1";
	}

	public void stickerButton2()
	{

		Rigidbody2D clone;
		clone = Instantiate (sticker [1], new Vector3 (Random.Range (-15, 9), Random.Range (7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker2";
		
	}

	public void stickerButton3()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[2], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker3";
	}

	public void stickerButton4()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[3], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker4";
	}

	public void stickerButton5()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[4], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker5";
	}

	public void stickerButton6()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[5], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker6";
	}

	public void stickerButton7()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[6], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker7";
	}

	public void stickerButton8()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[7], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker8";
	}

	public void stickerButton9()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[8], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker9";
	}

	public void stickerButton10()
	{
		Rigidbody2D clone;
		clone = Instantiate (sticker[9], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
		clone.name = "sticker10";
	}

	public void backToMainMenu()
	{
		levelToLoad = 0;
		toMainMenu = true;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
	}

	public void delete()
	{
		deleteFlag = true;
	}
}

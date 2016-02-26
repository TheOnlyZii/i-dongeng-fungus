using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Soomla.Store;
using System.IO;

public class mainMenuUI : MonoBehaviour {

	public GameObject ChapterPanel;
	public GameObject mainMenuPanel;
	public GameObject episodePanel;
	public GameObject buyPanel;
	public GameObject puzzlePanel;
	public GameObject bookSmallPanel;
	public GameObject puzzleSmallPanel;
	public GameObject stickerPanel;
	public GameObject tempelPanel;
	public GameObject mainCamera;
	public GameObject BuyEpisode2;
	public GameObject BuyEpisode3;
	public GameObject saveHolder;
	public GameObject loadingScreen;
	public GameObject exitConfirmation;
	public GameObject[] stickerUnlockList;
	public GameObject[] templateSaveList;
	public int levelToLoad;
	public int[] stickerToggle;
	public int[] saveDataExist;

	public static bool menuToPaintStatus = false;
	public static bool menuToCocokGambarStatus = false;
	public static bool menuToEp1Sc2 = false;
	public static bool menuToEp1Sc4 = false;
	public static bool menuToEp1Sc5 = false;
	public static bool menuToEp1Sc6 = false;
	public static bool menuToEp1Sc8 = false;
	public static bool menuToEp1Sc9 = false;
	public static bool loadFlag1 = false;
	public static bool loadFlag2 = false;
	public static bool loadFlag3 = false;
	public static bool loadFlag4 = false;
	public static bool loadFlag5 = false;

	public string url;
	public Sprite[] buttonSSImage;

	AudioSource bgmAudio;

	bool buttonflag = false;
	bool puzzleflag = false;
	bool soundToggle = true;
	bool BuyEpisode2toggle = false;
	bool BuyEpisode3toggle = false;

	[SerializeField] private Button rekamanButton = null;
	[SerializeField] private Button narasiButton = null;

	void Start()
	{
		bgmAudio = mainCamera.GetComponent<AudioSource> ();
		//rekamanButton.onClick.AddListener (() => {modeManager.instance.changeMode();});
		//narasiButton.onClick.AddListener (() => {modeManager.instance.changeMode();});

		//modeManager.instance.statusMode = false;

		url = Application.persistentDataPath;

		templateSaveValidator ();
	}

	void Update()
	{
		stickerValidator ();
		openExit ();
	}

	public void OnLevelWasLoaded(int level)
	{
		if (level == 0 && stickerManager.toMainMenu == true) {
			tempelPanel.SetActive(true);
			stickerManager.toMainMenu = false;
		}
	}

	public void stickerValidator()
	{
		stickerToggle [0] = PlayerPrefs.GetInt ("sticker1-1");
		stickerToggle [1] = PlayerPrefs.GetInt ("sticker1-2");

		if (stickerToggle [0] == 1) {
			stickerUnlockList [0].SetActive (true);
			stickerUnlockList [2].GetComponent<Image>().enabled = false;
		} else {
			stickerUnlockList [0].SetActive (false);
			stickerUnlockList [2].GetComponent<Image>().enabled = true;
		}

		if (stickerToggle [1] == 1) {
			stickerUnlockList [1].SetActive (true);
			stickerUnlockList [3].GetComponent<Image>().enabled = false;
		} else {
			stickerUnlockList [1].SetActive (false);
			stickerUnlockList [3].GetComponent<Image>().enabled = true;
		}
	}

	public void templateSaveValidator()
	{
		saveDataExist [0] = PlayerPrefs.GetInt ("save1Exist");
		saveDataExist [1] = PlayerPrefs.GetInt ("save2Exist");
		saveDataExist [2] = PlayerPrefs.GetInt ("save3Exist");
		saveDataExist [3] = PlayerPrefs.GetInt ("save4Exist");
		saveDataExist [4] = PlayerPrefs.GetInt ("save5Exist");

		if (saveDataExist[0] == 1) {
			templateSaveList [0].GetComponent<Button> ().interactable = true;
//			loadStickerSS();
//			templateSaveList[0].GetComponent<Image>().sprite = buttonSSImage[0];
		}
		else {
			templateSaveList [0].GetComponent<Button> ().interactable = false;
		}
		if (saveDataExist[1] == 1) {
			templateSaveList [1].GetComponent<Button> ().interactable = true;
//			loadStickerSS2();
//			templateSaveList[1].GetComponent<Image>().sprite = buttonSSImage[1];
		}
		else {
			templateSaveList [1].GetComponent<Button> ().interactable = false;
		}
		if (saveDataExist[2] == 1) {
			templateSaveList [2].GetComponent<Button> ().interactable = true;
//			loadStickerSS3();
//			templateSaveList[2].GetComponent<Image>().sprite = buttonSSImage[2];
		}
		else {
			templateSaveList [2].GetComponent<Button> ().interactable = false;
		}
		if (saveDataExist[3] == 1) {
			templateSaveList [3].GetComponent<Button> ().interactable = true;
		}
		else {
			templateSaveList [3].GetComponent<Button> ().interactable = false;
		}
		if (saveDataExist[4] == 1) {
			templateSaveList [4].GetComponent<Button> ().interactable = true;
		}
		else {
			templateSaveList [4].GetComponent<Button> ().interactable = false;
		}
	}

	IEnumerator DisplayLoadingScreen(int level)
	{
		loadingScreen.SetActive (true);

		AsyncOperation async =  Application.LoadLevelAsync (level);

		if (async.isDone)
			levelToLoad = 0;
		yield return null;
	}

	public void loadStickerSS()
	{
		Texture2D tex = null;
		byte[] fileData;
		string sName = url + "/screenshot/" + "Screenshot_1" + ".png";

		if (File.Exists(sName)){
			Debug.Log ("SS exist");
			fileData = File.ReadAllBytes(sName);
			tex = new Texture2D(2,2);
			tex.LoadImage(fileData);
			
			buttonSSImage[0] = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0.5f,0.5f));
		}
	}

	public void loadStickerSS2()
	{
		Texture2D tex = null;
		byte[] fileData;
		string sName = "file:///" + url + "/screenshot/" + "Screenshot_2" + ".png";
		
		if (File.Exists(sName)){
			Debug.Log ("SS exist");
			fileData = File.ReadAllBytes(sName);
			tex = new Texture2D(2,2);
			tex.LoadImage(fileData);
			
			buttonSSImage[1] = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0.5f,0.5f));
		}
	}

	public void loadStickerSS3()
	{
		Texture2D tex = null;
		byte[] fileData;
		string sName = "file:///" + url + "/screenshot/" + "Screenshot_3" + ".png";
		
		if (File.Exists(sName)){
			Debug.Log ("SS exist");
			fileData = File.ReadAllBytes(sName);
			tex = new Texture2D(2,2);
			tex.LoadImage(fileData);
			
			buttonSSImage[2] = Sprite.Create(tex,new Rect(0,0,tex.width,tex.height),new Vector2(0.5f,0.5f));
		}
	}


	public void ChapterSelect()
	{
		ChapterPanel.SetActive(true);
		mainMenuPanel.SetActive (false);
	}

	public void ChapterToEpisode()
	{
		episodePanel.SetActive (true);
		ChapterPanel.SetActive (false);
	}

	public void ChapterbackMainMenu()
	{
		ChapterPanel.SetActive (false);
		mainMenuPanel.SetActive (true);
	}

	public void backtoChapter()
	{
		episodePanel.SetActive (false);
		ChapterPanel.SetActive (true);
	}

	public void MainMenutoSticker()
	{
		stickerPanel.SetActive (true);
		mainMenuPanel.SetActive (false);
	}

	public void stickerToMainMenu()
	{
		stickerPanel.SetActive (false);
		mainMenuPanel.SetActive (true);
	}

	public void BuyPanel(bool flag)
	{
		if(flag == false)
		{
			flag = true;
			buyPanel.SetActive(flag);
		}
		else
		{
			flag = false;
			buyPanel.SetActive(flag);
		}
	}

	public void PuzzlePanel(bool flag)
	{
		if(flag == false)
		{
			flag = true;
			puzzlePanel.SetActive(flag);
		}
		else
		{
			flag = false;
			puzzlePanel.SetActive(flag);
		}
	}

	public void bookButton()
	{
		if(buttonflag == false)
		{
			buttonflag = true;
			bookSmallPanel.SetActive(buttonflag);
		}
		else
		{
			buttonflag = false;
			bookSmallPanel.SetActive(buttonflag);
		}

		if(puzzleSmallPanel == true)
		{
			puzzleflag = false;
			puzzleSmallPanel.SetActive(puzzleflag);
		}
	}

	public void puzzleButton()
	{
		if(puzzleflag == false)
		{
			puzzleflag = true;
			puzzleSmallPanel.SetActive(puzzleflag);
		}
		else
		{
			puzzleflag = false;
			puzzleSmallPanel.SetActive(puzzleflag);
		}

		if(bookSmallPanel == true)
		{
			buttonflag = false;
			bookSmallPanel.SetActive(buttonflag);
		}
	}

	public void KoleksiToTempel()
	{
		stickerPanel.SetActive (false);
		tempelPanel.SetActive (true);
	}

	public void TempelToKoleksi()
	{
		stickerPanel.SetActive (true);
		tempelPanel.SetActive (false);
	}

	public void ToTempelStickerScene()
	{
		levelToLoad = 1;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
	}

	public void ToTempelStickerScene2()
	{
		levelToLoad = 4;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
	}

	public void ToTempelStickerScene3()
	{
		Application.LoadLevel (5);
	}

	public void ToTempelStickerScene4()
	{
		Application.LoadLevel (6);
	}
	public void ToTempelStickerScene5()
	{
		Application.LoadLevel (7);
	}

	public void LoadStickerScene1()
	{
		levelToLoad = 1;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		loadFlag1 = true;
	}

	public void LoadStickerScene2()
	{
		levelToLoad = 4;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		loadFlag2 = true;
	}

	public void LoadStickerScene3()
	{
		levelToLoad = 5;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		loadFlag3 = true;
	}

	public void LoadStickerScene4()
	{
		levelToLoad = 6;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		loadFlag4 = true;
	}

	public void LoadStickerScene5()
	{
		levelToLoad = 7;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		loadFlag5 = true;
	}

	public void ToEpisode1()
	{
		levelToLoad = 1;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
	}

	public void toggleSound()
	{
		if(soundToggle)
		{
			soundToggle = false;
			bgmAudio.Stop();
		}
		else
		{
			soundToggle = true;
			bgmAudio.Play();
		}
	}

	public void rateApp()
	{
		Application.OpenURL ("https://play.google.com/store/apps/details?id=com.Amplified.SaveTheSheep");
	}

	public void goToPaint()
	{
		//when clicked, go to paint scene in scene 3
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToPaintStatus = true;
	}

	public void goToCocokGambar()
	{
		//when clicked, go to game cocok gambar
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToCocokGambarStatus = true;
	}

	public void goToEp1Sc1()
	{
		//when clicked, go to scene 1
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
	}

	public void goToEp1Sc2()
	{
		//when clicked, go to scene 2
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc2 = true;
	}

	public void goToEp1Sc4()
	{
		//when clicked, go to scene 4
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc4 = true;
	}

	public void goToEp1Sc5()
	{
		//when clicked, go to scene 5
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc5 = true;
	}

	public void goToEp1Sc6()
	{
		//when clicked, go to scene 6
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc6 = true;
	}

	public void goToEp1Sc8()
	{
		//when clicked, go to scene 8
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc8 = true;
	}

	public void goToEp1Sc9()
	{
		//when clicked, go to scene 9
		levelToLoad = 2;
		StartCoroutine (DisplayLoadingScreen (levelToLoad));
		menuToEp1Sc9 = true;
	}

	public void BuyEpisode2Box()
	{
		if(!BuyEpisode2toggle)
		{
			BuyEpisode2.SetActive(true);
			BuyEpisode2toggle = true;
		}
		else
		{
			BuyEpisode2.SetActive(false);
			BuyEpisode2toggle = false;
		}
	}

	public void BuyEpisode3Box()
	{
		if(!BuyEpisode3toggle)
		{
			BuyEpisode3.SetActive(true);
			BuyEpisode3toggle = true;
		}
		else
		{
			BuyEpisode3.SetActive(false);
			BuyEpisode3toggle = false;
		}
	}

	public void openExit()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			exitConfirmation.SetActive(true);
		}
	}

	public void exitGame()
	{
		Application.Quit ();
	}

	public void closeExit()
	{
		exitConfirmation.SetActive (false);
	}
}
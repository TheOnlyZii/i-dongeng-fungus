using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]
public class SaveScript : MonoBehaviour{
	//stickerController stickerControl;
	public GameObject[] sticker;

	// saving state data
//	private List<Dictionary<GameObject, SavedState>> mSavedStates = new List<Dictionary<GameObject, SavedState>>();
//
//	public static SaveScript Instance;

	void Awake()
	{
//		DontDestroyOnLoad (this);
//
//		if (FindObjectsOfType(GetType()).Length > 1)
//		{
//			Destroy(gameObject);
//		}
	}

	// Use this for initialization
	void Start () {
		//stickerControl = GetComponent<stickerController> ();
	}
	
	// Update is called once per frame
	void Update () {
//		FindSticker ();
	}

//	public void FindSticker()
//	{
//		GameObject[] GO = GameObject.FindGameObjectsWithTag ("sticker");
//		int count = 0;
//		foreach (GameObject gObject in GO) {
//			count += 1;
//			Debug.Log("Object " + count + " : " + gObject);
//		}
//
//		Debug.Log("Total object in array : " + count);
//	}

//	public class SavedState
//	{
//		public GameObject GO;
//		public Vector3 GOposition;
//		public Quaternion GOrotation;
//		public Vector3 GOScaleLocal;
//	}
	
	public void SaveCurrentScene()
	{
		GameObject[] gos = GameObject.FindGameObjectsWithTag ("sticker");
		int count = 0;
		
		
		//add object to dict
		SaveLoad.savedGames.Clear ();
		foreach(GameObject go in gos)
		{
			count += 1;

			Debug.Log("nama : "+go.gameObject.name);

			if(go.gameObject.name == "sticker1" || go.gameObject.name == "Sticker 1(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker1"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker2" || go.gameObject.name == "Sticker 2(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker2"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker3" || go.gameObject.name == "Sticker 3(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker3"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker4" || go.gameObject.name == "Sticker 4(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker4"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker5" || go.gameObject.name == "Sticker 5(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker5"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker6" || go.gameObject.name == "Sticker 6(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker6"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker7" || go.gameObject.name == "Sticker 7(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker7"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker8"|| go.gameObject.name == "Sticker 8(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker8"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker9" || go.gameObject.name == "Sticker 9(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker9"
				};
				SaveLoad.savedGames.Add(state);
			}

			if(go.gameObject.name == "sticker10" || go.gameObject.name == "Sticker 10(Clone)")
			{
				StickerClass state = new StickerClass()
				{
					position = go.transform.position,
					rotation = go.transform.rotation,
					scaleLocal = go.transform.localScale,
					stickerName = "sticker10"
				};
				SaveLoad.savedGames.Add(state);
			}

			Debug.Log(go + " " + count );
		}

		if (Application.loadedLevel == 1) {
			SaveLoad.Save ();
			PlayerPrefs.SetInt("save1Exist", 1);
			PlayerPrefs.SetInt("save1ss", 1);
		}
		else if(Application.loadedLevel == 4)
		{
			SaveLoad.Save2();
			PlayerPrefs.SetInt("save2Exist", 1);
			PlayerPrefs.SetInt("save2ss", 1);
		}
		else if(Application.loadedLevel == 5)
		{
			SaveLoad.Save3();
			PlayerPrefs.SetInt("save3Exist", 1);
			PlayerPrefs.SetInt("save3ss", 1);
		}
		else if(Application.loadedLevel == 6)
		{
			SaveLoad.Save4();
			PlayerPrefs.SetInt("save4Exist", 1);
			PlayerPrefs.SetInt("save4ss", 1);
		}
		else if(Application.loadedLevel == 7)
		{
			SaveLoad.Save5();
			PlayerPrefs.SetInt("save5Exist", 1);
			PlayerPrefs.SetInt("save5ss", 1);
		}
//		GameObject[] gos = GameObject.FindGameObjectsWithTag ("sticker");
//		int count = 0;
//
////		//create current time state
//		Dictionary<GameObject, SavedState> stateData = new Dictionary<GameObject, SavedState> ();
//
//		//add object to dict
//		foreach(GameObject go in gos)
//		{
//			count += 1;
//			SavedState state = new SavedState()
//			{
//				GO = go,
//				GOposition = go.transform.position,
//				GOrotation = go.transform.rotation,
//				GOScaleLocal = go.transform.localScale
//			};
//
//			Debug.Log(go + " " + count );
//			Debug.Log ("Save Successfull");
//
//
//			stateData[go] = state;
//		}
//		mSavedStates.Add(stateData);
	}

	public void LoadCurrentScene()
	{
		if (Application.loadedLevel == 1) {
			SaveLoad.Load ();
		}
		else if(Application.loadedLevel == 4)
		{
			SaveLoad.Load2 ();
		}
		else if(Application.loadedLevel == 5)
		{
			SaveLoad.Load3 ();
		}
		else if(Application.loadedLevel == 6)
		{
			SaveLoad.Load4 ();
		}
		else if(Application.loadedLevel == 7)
		{
			SaveLoad.Load5 ();
		}

		Debug.Log ("count : "+SaveLoad.savedGames.Count);

		GameObject go;
		int c = 0;
		foreach (StickerClass st in SaveLoad.savedGames) {
			Rigidbody2D clone;
			if(st.stickerName == "sticker1")
			{
				clone = Instantiate (sticker[0], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker2")
			{
				clone = Instantiate (sticker[1], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker3")
			{
				clone = Instantiate (sticker[2], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker4")
			{
				clone = Instantiate (sticker[3], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker5")
			{
				clone = Instantiate (sticker[4], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker6")
			{
				clone = Instantiate (sticker[5], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker7")
			{
				clone = Instantiate (sticker[6], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker8")
			{
				clone = Instantiate (sticker[7], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker9")
			{
				clone = Instantiate (sticker[8], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			if(st.stickerName == "sticker10")
			{
				clone = Instantiate (sticker[9], new Vector3 (Random.Range(-15,9),Random.Range(7, -7), 0), Quaternion.identity) as Rigidbody2D;
			}

			//go = st.sticker;
			go = GameObject.FindGameObjectsWithTag ("sticker")[c];
			go.transform.position = st.position;
			go.transform.rotation = st.rotation;
			go.transform.localScale = st.scaleLocal;
			c++;
		}

//		GameObject go;
//		for (int i=0; i<SaveLoad.savedGames.Count; i++) {
//
//
//			if((GameObject)SaveLoad.savedGames[i].sticker == null)
//			{
//				Debug.Log ("object null");
//			}
//
//			go = SaveLoad.savedGames[i].sticker;
//			go.transform.position = SaveLoad.savedGames[i].position;
//			go.transform.rotation = SaveLoad.savedGames[i].rotation;
//			go.transform.localScale = SaveLoad.savedGames[i].scaleLocal;
//		}
	}

//	private void SetGosStateByDict(Dictionary<GameObject, SavedState> currentStateData)
//	{
//		// restore time data
//		foreach (KeyValuePair<GameObject, SavedState> kvp in currentStateData)
//		{
//			SavedState savedData = kvp.Value;
//			GameObject goToRestore = savedData.GO;
//
//			// restore transformations
//			Instantiate(savedData.GO);
//			goToRestore.transform.position = savedData.GOposition;
//			goToRestore.transform.rotation = savedData.GOrotation;
//			goToRestore.transform.localScale = savedData.GOScaleLocal;
//		}
//	}

}

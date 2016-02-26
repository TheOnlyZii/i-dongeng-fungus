using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class cekRecordForPlayButton : MonoBehaviour {

	public string path;

	// Use this for initialization
	void OnEnable () {
		CheckRecord();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CheckRecord()
	{
		if (System.IO.File.Exists(Application.persistentDataPath+path))
		{
			this.transform.GetComponent<Button>().interactable = true;
			print("ada kok");
		}
		else
		{
			this.transform.GetComponent<Button>().interactable = false;
			print("gak ada kok");
		}
	}
}

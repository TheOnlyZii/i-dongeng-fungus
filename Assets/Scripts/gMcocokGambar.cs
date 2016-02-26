using UnityEngine;
using System.Collections;

public class gMcocokGambar : MonoBehaviour {

	public int charNumber;
	public int bananaNumber;
	public ParticleSystem firework;
	AudioSource awardSound;

	public GameObject[] nomorPisang;
	public GameObject[] tandaPanah;
	public GameObject sceneMan;
	public bool[] pisangDone;
	public bool awardFlag = false;

	// Use this for initialization
	void Start () {
		awardSound = GetComponent<AudioSource> ();
		sceneMan = GameObject.Find ("sceneManager");
	}
	
	// Update is called once per frame
	void Update () {

		awardScreen ();

		if(awardFlag)
		{
			firework.Play();
			awardSound.Play();
			awardFlag = false;
		}
		else
		{
			firework.Stop();
		}
	}
	
	public void awardScreen()
	{
		//activate award when all pisangDone is true
		if(pisangDone[0] == true && pisangDone[1] == true && pisangDone[2] == true && pisangDone[3] == true)
		{
			//award code here
			if(PlayerPrefs.GetInt("sticker1-2") == 0)
			{
				//sceneMan.GetComponent<sceneManager>().rewardScreens[1].SetActive(true);
			}
			else
			{
				//sceneMan.GetComponent<sceneManager>().rewardScreens[1].SetActive(false);
			}
			//sceneMan.GetComponent<sceneManager>().buttonScene7flag = true;
			awardFlag = true;
			pisangDone[0] = false;
			PlayerPrefs.SetInt("sticker1-2", 1);
		}
	}
}

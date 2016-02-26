using UnityEngine;
using System.Collections;

public class episodeAnimScript : MonoBehaviour {

	public GameObject[] episodeList;
	public GameObject menuUIHolder;
	int episodeNum = 0;

	mainMenuUI menuUI;
	Animator anim;

	void Awake()
	{

	}

	// Use this for initialization
	void Start () {
		menuUI = menuUIHolder.GetComponent<mainMenuUI> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NextClicked()
	{
		if(episodeNum == 0)
		{
			episodeList[0].SetActive(false);
			episodeList[1].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 1;
		}
		else if(episodeNum == 1)
		{
			episodeList[1].SetActive(false);
			episodeList[2].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 2;
		}
		else if(episodeNum == 2)
		{
			episodeList[2].SetActive(false);
			episodeList[3].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 3;
		}
		else if(episodeNum == 3)
		{
			episodeList[3].SetActive(false);
			episodeList[4].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 4;
		}
		else
		{
			episodeList[4].SetActive(false);
			episodeList[0].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 0;
		}
	}

	public void PrevClicked()
	{
		if(episodeNum == 0)
		{
			episodeList[0].SetActive(false);
			episodeList[4].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 4;
		}
		else if(episodeNum == 1)
		{
			episodeList[1].SetActive(false);
			episodeList[0].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 0;
		}
		else if(episodeNum == 2)
		{
			episodeList[2].SetActive(false);
			episodeList[1].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 1;
		}
		else if(episodeNum == 3)
		{
			episodeList[3].SetActive(false);
			episodeList[2].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 2;
		}
		else
		{
			episodeList[4].SetActive(false);
			episodeList[3].SetActive(true);
			menuUI.bookSmallPanel.SetActive(false);
			menuUI.puzzleSmallPanel.SetActive(false);
			episodeNum = 3;
		}
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StickerBook : MonoBehaviour {

	public GameObject[] halamanSticker;
	public GameObject[] buttons;
	public Sprite buttonOn;
	public Sprite buttonOff;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if(halamanSticker[0].activeSelf == true)
			buttons[0].GetComponent<Image>().sprite = buttonOn;
		else
			buttons[0].GetComponent<Image>().sprite = buttonOff;

		if(halamanSticker[1].activeSelf == true)
			buttons[1].GetComponent<Image>().sprite = buttonOn;
		else
			buttons[1].GetComponent<Image>().sprite = buttonOff;

		if(halamanSticker[2].activeSelf == true)
			buttons[2].GetComponent<Image>().sprite = buttonOn;
		else
			buttons[2].GetComponent<Image>().sprite = buttonOff;


	}

	public void bukaHalaman1()
	{
		halamanSticker [0].SetActive (true);
		halamanSticker [1].SetActive (false);
		halamanSticker [2].SetActive (false);
	}

	public void bukaHalaman2()
	{
		halamanSticker [0].SetActive (false);
		halamanSticker [1].SetActive (true);
		halamanSticker [2].SetActive (false);
	}

	public void bukaHalaman3()
	{
		halamanSticker [0].SetActive (false);
		halamanSticker [1].SetActive (false);
		halamanSticker [2].SetActive (true);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class screenFader : MonoBehaviour {

	public GameObject faderObject;
	public Image fader;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FadeIn()
	{
		faderObject.SetActive (true);
		Debug.Log ("active");
		faderObject.GetComponent<Image>().CrossFadeAlpha (255, 10f, false);
	}

	public void FadeOut()
	{
		fader.CrossFadeAlpha (0, 1f, false);
		//faderObject.SetActive (false);
	}
}

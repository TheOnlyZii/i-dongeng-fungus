using UnityEngine;
using System.Collections;

public class objectInteractScript : MonoBehaviour {

	public int value;

	public string[] originalVOname;
	public string[] userVOname;

	public GameObject audiosourceGO;

	AudioSource audiosource;
	AudioClip audioclip;

	// Use this for initialization
	void Start () 
	{
		audiosource = audiosourceGO.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() 
	{
		gameObject.GetComponent<Animation>().Play();


	}
}

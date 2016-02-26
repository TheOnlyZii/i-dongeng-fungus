using UnityEngine;
using System.Collections;

public class narasiManager : MonoBehaviour 
{

	/// <summary>
	/// CUMA BUAT ATUR NARASI PER EPISODE, NARASI YANG DI ATUR ADALAH PERSCENE DAN PER SUBSCENE
	/// TIDAK MENGATUR UI, HANYA AUDIO DAN ANIMASI PER AUDIO
	/// </summary>

	int scene;
	int subscene;

	public AudioSource source;
	public AudioSource sourceBGM;

	public AudioClip clipSource;

	public GameObject audioSourceNarasi;
	public Transform EP1Scenes;




	// Use this for initialization
	void Start () 
	{
		scene = staticVal.scene;
		subscene = staticVal.subscene;
		source = audioSourceNarasi.GetComponent<AudioSource>();
		sourceBGM = GameObject.Find("Main Camera").GetComponent<AudioSource>();
	}



	public void userVOplay(string val)
	{
		clipSource = Resources.Load("userVO/"+val) as AudioClip;
		source.clip = clipSource;
		source.Play ();
	}
	
	public void oriVOplay(string val)
	{
		clipSource = Resources.Load("Ep1Ori/"+val) as AudioClip;
		source.clip = clipSource;
		source.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//print(staticVal.subscene);

		if(staticVal.scene == 1)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-1.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-1");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 1");
					staticVal.subscene = 2;
				}

			}

			if(staticVal.subscene == 2 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-2.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-2");
					staticVal.subscene = 3;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 2 VO 1");
					staticVal.subscene = 3;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(0).transform.GetChild(0).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 3 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-3.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-3");
					staticVal.subscene = 4;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 2 VO 2");
					staticVal.subscene = 4;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(0).transform.GetChild(1).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 4 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-4.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-4");
					staticVal.subscene = 5;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 2 VO 3");
					staticVal.subscene = 5;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(0).transform.GetChild(2).GetComponent<Animation>().Play();
			}
		}

		/////// SCENE 2 ///////

		else if(staticVal.scene == 2)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-5.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-5");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 3 VO 1 Kakek");
					staticVal.subscene = 2;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(1).transform.GetChild(0).GetComponent<Animation>().Play();

			}
			
			if(staticVal.subscene == 2 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-6.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-6");
					staticVal.subscene = 3;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 3 VO ANAK KERA 1");
					staticVal.subscene = 3;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(1).transform.GetChild(1).GetComponent<Animation>().Play();
			}

		}

		/////// SCENE 3 //////

		else if(staticVal.scene == 3)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-7.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-7");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 4 VO 1");
					staticVal.subscene = 2;
				}
			}
			
			if(staticVal.subscene == 2 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-8.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-8");
					staticVal.subscene = 3;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 4 VO 2");
					staticVal.subscene = 3;
				}
			}

			if(staticVal.subscene == 3 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-9.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-9");
					staticVal.subscene = 4;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 4 VO 3");
					staticVal.subscene = 4;
				}
			}
		}

		///// SCENE 4 atau 5 ///////////

		else if(staticVal.scene == 4)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-10.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-10");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 5 VO 1");
					staticVal.subscene = 2;
				}
			}
		}

		///// SCENE 6 ///////////

		else if(staticVal.scene == 5)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-11.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-11");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 6 VO 1");
					staticVal.subscene = 2;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(0).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 2 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-12.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-12");
					staticVal.subscene = 3;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 6 VO 2");
					staticVal.subscene = 3;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(1).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 3 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-13.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-13");
					staticVal.subscene = 4;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 6 VO 3");
					staticVal.subscene = 4;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(2).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 4 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-14.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-14");
					staticVal.subscene = 5;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 6 VO 4");
					staticVal.subscene = 5;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(0).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 5 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-14a.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-14a");
					staticVal.subscene = 6;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 7 VO 1");
					staticVal.subscene = 6;
				}
				
				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(4).gameObject.SetActive(true);
				EP1Scenes.GetChild(5).transform.GetChild(4).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 6 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-14b.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-14b");
					staticVal.subscene = 7;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 7 VO 2");
					staticVal.subscene = 7;
				}
				
				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(4).gameObject.SetActive(false);
				EP1Scenes.GetChild(5).transform.GetChild(3).gameObject.SetActive(true);
				EP1Scenes.GetChild(5).transform.GetChild(0).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 7 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-14c.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-14c");
					staticVal.subscene = 8;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 7 VO 3");
					staticVal.subscene = 8;
				}
				
				///PLAY ANIMASI
				EP1Scenes.GetChild(5).transform.GetChild(3).GetComponent<Animation>().Play();
			}
		}

		///// SCENE 7 ///////////

		else if(staticVal.scene == 6)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-15.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-15");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 1");
					staticVal.subscene = 2;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(0).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 2 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-16.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-16");
					staticVal.subscene = 3;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 2");
					staticVal.subscene = 3;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(1).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 3 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-17.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-17");
					staticVal.subscene = 4;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 3");
					staticVal.subscene = 4;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(0).GetComponent<Animation>().Play();
			}
			
			if(staticVal.subscene == 4 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-18.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-18");
					staticVal.subscene = 5;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 4");
					staticVal.subscene = 5;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(1).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 5 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-19.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-19");
					staticVal.subscene = 6;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 5");
					staticVal.subscene = 6;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(0).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 6 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-20.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-20");
					staticVal.subscene = 7;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 6");
					staticVal.subscene = 7;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(1).GetComponent<Animation>().Play();
				EP1Scenes.GetChild(6).transform.GetChild(2).GetComponent<Animation>().Play();
				EP1Scenes.GetChild(6).transform.GetChild(3).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 7 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-21.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-21");
					staticVal.subscene = 8;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 7");
					staticVal.subscene = 8;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(2).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 8 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-22.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-22");
					staticVal.subscene = 9;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 8");
					staticVal.subscene = 9;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(1).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 9 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-23.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-23");
					staticVal.subscene = 10;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 9");
					staticVal.subscene = 10;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(2).GetComponent<Animation>().Play();
			}

			if(staticVal.subscene == 10 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-24.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-24");
					staticVal.subscene = 11;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 9 VO 10");
					staticVal.subscene = 11;
				}

				///PLAY ANIMASI
				EP1Scenes.GetChild(6).transform.GetChild(0).GetComponent<Animation>().Play();
			}
		}

		///// SCENE 8 ///////////

		else if(staticVal.scene == 7)
		{
			if(staticVal.subscene == 1 && !source.isPlaying && !staticVal.audioPause)
			{
				if (System.IO.File.Exists(Application.persistentDataPath+"/Resources/userVO/VOuserEP1-25.wav"))
				{
					print("ada");
					userVOplay("VOuserEP1-25");
					staticVal.subscene = 2;
					
				}
				else
				{
					print("tidak ada");
					oriVOplay("SCENE 10 VO 1");
					staticVal.subscene = 2;
				}
			}
		}
	}
}

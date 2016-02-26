using UnityEngine;
using System.Collections;
using System;

public class SceneManager : MonoBehaviour {

	/// <summary>
	/// MENGATUR SCENE, DALAM HAL INI PERGERAKAN KAMERA PER SCENE DALAM TIAP EPISODE
	/// </summary>

	int EP1 = 0;
	int scene;
	bool flag = false;
	bool flag2 = false;

	public float timer;
	public AudioSource source;
	public AudioSource sourceBGM;

	public GameObject camera;
	public GameObject EP1UIMAnager;
	public GameObject EP1ScenesManager;

	// Use this for initialization
	void Start () 
	{
		flag = false;
		source = GameObject.Find("narasiAudiManager").GetComponent<AudioSource>();
		sourceBGM = GameObject.Find("Main Camera").GetComponent<AudioSource>();
		timer = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(staticVal.scene == 1)
		{
			if(!flag)
			{
				camera.transform.position = new Vector3(-18, 0, camera.transform.position.z);
				scene1Special();
				flag = true;
			}

			if(camera.transform.position.x < 0)
			{
				GetComponent<UImanager>().EP1.transform.GetChild(1).gameObject.SetActive(false);
				camera.transform.Translate(Vector3.right * Time.deltaTime * 1.0f, Space.World);
			}
			else
			{
				//canvas.SetActive(true);
				GetComponent<UImanager>().UISceneToggle(0);
			}
		}
		else if(staticVal.scene == 2)
		{
			if(!flag)
			{
				sceneGeneral(1,0,-30,1);
				flag = true;
			}
		}

		else if(staticVal.scene == 3)
		{
			if(!flag)
			{
				sceneGeneral(2,-50,-30,2);
				flag = true;
			}
		}

		else if(staticVal.scene == 4) // buat scene 5, original developer just f*cked up
		{
			if(!flag)
			{
				sceneGeneral(3,50,-30,3);
				flag = true;
			}
			else
			{
				timer -= Time.deltaTime;
				
				if(timer <= 0)
				{
					scene4Special();
					
					if(!flag2)
					{
						camera.transform.position = new Vector3(0, -60, camera.transform.position.z);
						flag2 = true;
					}
					else
					{
						if(camera.transform.position.y > -80)
						{
							camera.transform.Translate(Vector3.down * Time.deltaTime * 0.5f, Space.World);
						}
					}

				}
			}
		}

		else if(staticVal.scene == 5)
		{
			if(!flag)
			{
				sceneGeneral(5,0,-120,5);
				flag = true;
			}
		}

		else if(staticVal.scene == 6)
		{
			if(!flag)
			{
				sceneGeneral(6,50,-120,6);
				flag = true;
			}
		}

		else if(staticVal.scene == 7)
		{
			if(!flag)
			{
				sceneGeneral(7,90,-120,7);
				flag = true;
			}
		}

		else if(staticVal.scene == 8)
		{
			if(!flag)
			{
				GetComponent<UImanager>().UISceneToggle(8);
				flag = true;
			}
		}
	}

    internal static void LoadScene(string sceneToLoad)
    {
        throw new NotImplementedException();
    }

    public void stopAudioChangeScene()
	{
		source.Stop();
		sourceBGM.Stop();
	}

	void scene1Special()
	{
		for(int i = 0; i <= 7; i++)
		{
			EP1ScenesManager.transform.GetChild(i).gameObject.SetActive(false);
		}
		
		EP1ScenesManager.transform.GetChild(0).gameObject.SetActive(true);
	}

	void scene4Special()
	{
		for(int i = 0; i <= 7; i++)
		{
			EP1ScenesManager.transform.GetChild(i).gameObject.SetActive(false);
		}
		
		EP1ScenesManager.transform.GetChild(4).gameObject.SetActive(true);
	}

	void sceneGeneral(int childScene, int cameraX, int cameraY, int uiSceneTog)
	{
		for(int i = 0; i <= 7; i++)
		{
			EP1ScenesManager.transform.GetChild(i).gameObject.SetActive(false);
		}
		
		EP1ScenesManager.transform.GetChild(childScene).gameObject.SetActive(true);

		camera.transform.position = new Vector3(cameraX,cameraY,-10);
		GetComponent<UImanager>().UISceneToggle(uiSceneTog);
	}

	public void nextScene()
	{
		if(staticVal.scene <= 7)
		{
			staticVal.scene += 1;
			staticVal.subscene = 1;
			flag = false;
			stopAudioChangeScene();
		}

		print(staticVal.scene );
	}

	public void prevScene()
	{
		if(staticVal.scene > 1)
		{
			staticVal.scene -= 1;
			staticVal.subscene = 1;
			flag = false;
			stopAudioChangeScene();
		}
		
		print(staticVal.scene );
	}
}

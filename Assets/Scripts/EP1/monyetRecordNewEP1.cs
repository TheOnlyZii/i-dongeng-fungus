using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monyetRecordNewEP1 : MonoBehaviour {

	/// <summary>
	/// MENGATUR SEGALA MACAM HAL YANG BERHUBUNGAN DENGAN RECORD VOICE, DAN JUGA MENGATUR UI YANG BERHUBUNGAN DENGAN RECORDING
	/// SEPERTI RECORD ICON, STOP RECORD ICON DAN PLAY ICON
	/// </summary>

	// Use this for initialization
	AudioClip VOuser; 
	public Toggle voiceOverRec;
	public int timer;

	public bool timerStart;
	public float timerpersec;

	public AudioSource forMusic;
	public AudioSource forNarasi;
	public AudioSource forbackgroundSFX;


	void Awake()
	{
		forMusic = GameObject.Find("Main Camera").GetComponent<AudioSource>();
		forNarasi = GameObject.Find("scenebackgroundSFX").GetComponent<AudioSource>();
		forbackgroundSFX = GameObject.Find("narasiAudiManager").GetComponent<AudioSource>();
	}

	void Start () 
	{


		timerStart = false;
		timerpersec = 1;
		timer = 1;

		//Check if audio exist for UI Display

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(timerStart)
		{
			timerpersec -= Time.deltaTime;
			if(timerpersec <= 0)
			{
				timer += 1;
				timerpersec = 1;
			}
		}
	}

	public void toggleRecordVal(int val)
	{
		voiceOverRec = this.gameObject.GetComponent<Toggle>();

		if(!voiceOverRec.isOn)
		{
			timerStart = true;
			recordNarasiStart();

		}
		else
		{
			recordNarasiEndEp1(val);
			timerStart = false;

		}

	}

	public void recordNarasiStart()
	{
		forMusic.Pause();
		forNarasi.Pause();
		forbackgroundSFX.Pause();
		staticVal.audioPause = true;
	
		VOuser =  Microphone.Start ( "Built-in Microphone", false, 20, 44100 );
	}

	public void recordNarasiEndEp1(int val)
	{
		AudioClip ac = VOuser;
		float lengthL = ac.length;
		float samplesL = ac.samples;
		float samplesPerSec = (float)samplesL/lengthL;
		float[] samples = new float[(int)(samplesPerSec * timer)];
		ac.GetData(samples,0);
		
		VOuser = AudioClip.Create("RecordedSound",(int)(timer*samplesPerSec),1,44100,false,false);
		
		VOuser.SetData(samples,0);

		Microphone.End("Built-in Microphone");
		SavWav.Save("VOuserEP1-"+val, VOuser);
		timer = 1;

		this.gameObject.transform.parent.GetChild(1).gameObject.SetActive(true);
		forMusic.UnPause();
		forNarasi.UnPause();
		forbackgroundSFX.UnPause();
		staticVal.audioPause = false;
	}


}

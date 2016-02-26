/*
Script made by: Mathijs van Sambeek
For more tutorials: https://www.youtube.com/user/0Imagineer0?sub_confirmation=1

This script can be used for free if you give credits to the maker of the script.
*/

using System.Collections;
using System.IO;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour {
 
 public bool controlable = false;
 public float moveSpeed = 1;
 public int resolution = 1; // 1= default, 2= 2x default, etc.
 public string imageName = "Screenshot_";
	public string imageName1 = "Screenshot_1.png";
	public string imageName2 = "/screenshot/Screenshot_2.png";
	public string imageName3 = "/screenshot/Screenshot_3.png";
	public string imageName4 = "/screenshot/Screenshot_4.png";
	public string imageName5 = "/screenshot/Screenshot_5.png";
 public string customPath; // leave blank for project file location
	public string androidPath;
	public string ssFolder = "/storage/emulated/0/DCIM/I-Dongeng/";
	public string ssNewLoc;
 public bool resetIndex = false;
 
 private int index = 0;
 
 void Awake()
 {
  customPath = Application.persistentDataPath + "/screenshot/";

  if(resetIndex) PlayerPrefs.SetInt("ScreenshotIndex", 0);

  if(customPath != "")
  {
   if(!System.IO.Directory.Exists(customPath))
   {
    System.IO.Directory.CreateDirectory(customPath);
   }
  }

		if(!System.IO.Directory.Exists(ssFolder)){
			System.IO.Directory.CreateDirectory(ssFolder);
		}
  index = PlayerPrefs.GetInt("ScreenshotIndex") != 0 ? PlayerPrefs.GetInt("ScreenshotIndex") : 1;
 }
 
	private IEnumerator TakeSS()
	{
		yield return new WaitForEndOfFrame();
		
		//INITIAL SETUP
		string myFilename = "myScreenshot.png";
		string myDefaultLocation = Application.persistentDataPath + "/" + myFilename;
		
		//EXAMPLE OF DIRECTLY ACCESSING THE Camera FOLDER OF THE GALLERY
		//string myFolderLocation = "/storage/emulated/0/DCIM/Camera/";
		//EXAMPLE OF BACKING INTO THE Camera FOLDER OF THE GALLERY
		//string myFolderLocation = Application.persistentDataPath + "/../../../../DCIM/Camera/";
		//EXAMPLE OF DIRECTLY ACCESSING A CUSTOM FOLDER OF THE GALLERY
		string myFolderLocation = "/storage/emulated/0/DCIM/I-Dongeng/";
		string myScreenshotLocation = myFolderLocation + myFilename;
		
		//ENSURE THAT FOLDER LOCATION EXISTS
		if(!System.IO.Directory.Exists(myFolderLocation)){
			System.IO.Directory.CreateDirectory(myFolderLocation);
		}
		
		//TAKE THE SCREENSHOT AND AUTOMATICALLY SAVE IT TO THE DEFAULT LOCATION.
		Application.CaptureScreenshot(myFilename);
		
		//MOVE THE SCREENSHOT WHERE WE WANT IT TO BE STORED
		System.IO.File.Copy(myDefaultLocation, myScreenshotLocation, true);
		
		//REFRESHING THE ANDROID PHONE PHOTO GALLERY IS BEGUN
		AndroidJavaClass classPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject>("currentActivity");        
		AndroidJavaClass classUri = new AndroidJavaClass("android.net.Uri");        
		AndroidJavaObject objIntent = new AndroidJavaObject("android.content.Intent", new object[2]{"android.intent.action.MEDIA_MOUNTED", classUri.CallStatic<AndroidJavaObject>("parse", "file://" + myScreenshotLocation)});        
		//REFRESHING THE ANDROID PHONE PHOTO GALLERY IS COMPLETE
		
		//AUTO LAUNCH/VIEW THE SCREENSHOT IN THE PHOTO GALLERY
		Application.OpenURL(myScreenshotLocation);
		
		//AFTERWARDS IF YOU MANUALLY GO TO YOUR PHOTO GALLERY, 
		//YOU WILL SEE THE FOLDER WE CREATED CALLED "myFolder"
	}

 void Update()
 {
  if(controlable)
  {
   if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
   {
    transform.Translate(0,0,(moveSpeed*Time.deltaTime) * 4);
   }
   else if(Input.GetKey(KeyCode.W))
   {
    transform.Translate(0,0,moveSpeed*Time.deltaTime);
   }
   if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
   {
    transform.Translate(0,0,-moveSpeed*Time.deltaTime * 4);
   }
   else if(Input.GetKey(KeyCode.S))
   {
    transform.Translate(0,0,-moveSpeed*Time.deltaTime);
   }
   if(Input.GetKey(KeyCode.A))
   {
    transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
   }
   else if(Input.GetKey(KeyCode.D))
   {
    transform.Translate(moveSpeed*Time.deltaTime, 0, 0);
   }
  }
 }
 
 void LateUpdate () 
  {
//  if(Input.GetKeyDown(KeyCode.L))
//  {
//    Application.CaptureScreenshot(customPath + imageName + index + ".png", resolution);
//    index++;
//    Debug.LogWarning("Screenshot saved: " + customPath + " --- " + imageName + index);
//  }
 }
	public void CaptureScreenshot()
	{
		if (Application.loadedLevel == 1) {
//			androidPath = Path.Combine (customPath, imageName1);
//			Application.CaptureScreenshot (androidPath);
//			ssNewLoc = ssFolder + imageName1;
//			System.IO.File.Move(androidPath, ssNewLoc);
//
//			//REFRESHING THE ANDROID PHONE PHOTO GALLERY IS BEGUN
//			AndroidJavaClass classPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
//			AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject>("currentActivity");        
//			AndroidJavaClass classUri = new AndroidJavaClass("android.net.Uri");        
//			AndroidJavaObject objIntent = new AndroidJavaObject("android.content.Intent", new object[2]{"android.intent.action.MEDIA_MOUNTED", classUri.CallStatic<AndroidJavaObject>("parse", "file://" + ssNewLoc)});        
//			objActivity.Call ("sendBroadcast", objIntent);
//			//REFRESHING THE ANDROID PHONE PHOTO GALLERY IS COMPLETE
//
//			Application.OpenURL(ssNewLoc);

			StartCoroutine(TakeSS());

			//Debug.LogWarning ("Screenshot saved: " + customPath + " --- " + imageName);
		}

		if (Application.loadedLevel == 4) {
			androidPath = Path.Combine (Application.persistentDataPath, imageName2);
			Application.CaptureScreenshot (androidPath);
			Debug.LogWarning ("Screenshot saved: " + customPath + " --- " + imageName);
		}

		if (Application.loadedLevel == 5) {
			androidPath = Path.Combine (Application.persistentDataPath, imageName3);
			Application.CaptureScreenshot (androidPath);
			Debug.LogWarning ("Screenshot saved: " + customPath + " --- " + imageName);
		}

		if (Application.loadedLevel == 6) {
			androidPath = Path.Combine (Application.persistentDataPath, imageName4);
			Application.CaptureScreenshot (androidPath);
			Debug.LogWarning ("Screenshot saved: " + customPath + " --- " + imageName);
		}

		if (Application.loadedLevel == 7) {
			androidPath = Path.Combine (Application.persistentDataPath, imageName5);
			Application.CaptureScreenshot (androidPath);
			Debug.LogWarning ("Screenshot saved: " + customPath + " --- " + imageName);
		}
	}
 
 void OnApplicationQuit()
 {
  PlayerPrefs.SetInt("ScreenshotIndex", (index));
 }
}
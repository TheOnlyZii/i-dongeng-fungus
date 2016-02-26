using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

[System.Serializable]

public static class SaveLoad {
	
	public static List<StickerClass> savedGames = new List<StickerClass>();
	
	public static void Save()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave.idf"))
		{
			Debug.Log("exist");	

			File.Delete(Application.persistentDataPath + "/stickerSave.idf");

			if(File.Exists(Application.persistentDataPath + "/stickerSave.idf"))
			{
				Debug.Log("exist2");	
			}else{
				Debug.Log("not nexist2");
			}
		}else{
			Debug.Log("not nexist");
		}

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/stickerSave.idf");
		bf.Serialize (file, savedGames);
		file.Close();
	}

	public static void Save2()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave2.idf"))
		{
			Debug.Log("exist");	
			
			File.Delete(Application.persistentDataPath + "/stickerSave2.idf");
			
			if(File.Exists(Application.persistentDataPath + "/stickerSave2.idf"))
			{
				Debug.Log("exist2");	
			}else{
				Debug.Log("not nexist2");
			}
		}else{
			Debug.Log("not nexist");
		}
		
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/stickerSave2.idf");
		bf.Serialize (file, savedGames);
		file.Close();
	}

	public static void Save3()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave3.idf"))
		{
			Debug.Log("exist");	
			
			File.Delete(Application.persistentDataPath + "/stickerSave3.idf");
			
			if(File.Exists(Application.persistentDataPath + "/stickerSave3.idf"))
			{
				Debug.Log("exist2");	
			}else{
				Debug.Log("not nexist2");
			}
		}else{
			Debug.Log("not nexist");
		}
		
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/stickerSave3.idf");
		bf.Serialize (file, savedGames);
		file.Close();
	}

	public static void Save4()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave4.idf"))
		{
			Debug.Log("exist");	
			
			File.Delete(Application.persistentDataPath + "/stickerSave4.idf");
			
			if(File.Exists(Application.persistentDataPath + "/stickerSave4.idf"))
			{
				Debug.Log("exist2");	
			}else{
				Debug.Log("not nexist2");
			}
		}else{
			Debug.Log("not nexist");
		}
		
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/stickerSave4.idf");
		bf.Serialize (file, savedGames);
		file.Close();
	}

	public static void Save5()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave5.idf"))
		{
			Debug.Log("exist");	
			
			File.Delete(Application.persistentDataPath + "/stickerSave5.idf");
			
			if(File.Exists(Application.persistentDataPath + "/stickerSave5.idf"))
			{
				Debug.Log("exist2");	
			}else{
				Debug.Log("not nexist2");
			}
		}else{
			Debug.Log("not nexist");
		}
		
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/stickerSave5.idf");
		bf.Serialize (file, savedGames);
		file.Close();
	}
	
	public static void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave.idf"))
		{
			savedGames.Clear();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/stickerSave.idf", FileMode.Open);
			SaveLoad.savedGames = (List<StickerClass>)bf.Deserialize(file);
			file.Close();
		}
	}

	public static void Load2()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave2.idf"))
		{
			savedGames.Clear();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/stickerSave2.idf", FileMode.Open);
			SaveLoad.savedGames = (List<StickerClass>)bf.Deserialize(file);
			file.Close();
		}
	}

	public static void Load3()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave3.idf"))
		{
			savedGames.Clear();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/stickerSave3.idf", FileMode.Open);
			SaveLoad.savedGames = (List<StickerClass>)bf.Deserialize(file);
			file.Close();
		}
	}

	public static void Load4()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave4.idf"))
		{
			savedGames.Clear();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/stickerSave4.idf", FileMode.Open);
			SaveLoad.savedGames = (List<StickerClass>)bf.Deserialize(file);
			file.Close();
		}
	}

	public static void Load5()
	{
		if(File.Exists(Application.persistentDataPath + "/stickerSave5.idf"))
		{
			savedGames.Clear();
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/stickerSave5.idf", FileMode.Open);
			SaveLoad.savedGames = (List<StickerClass>)bf.Deserialize(file);
			file.Close();
		}
	}
}


sealed class Vector3SerializationSurrogate : ISerializationSurrogate {
	
	// Method called to serialize a Vector3 object
	public void GetObjectData(System.Object obj,
	                          SerializationInfo info, StreamingContext context) {
		
		Vector3 v3 = (Vector3) obj;
		info.AddValue("x", v3.x);
		info.AddValue("y", v3.y);
		info.AddValue("z", v3.z);
		Debug.Log(v3);
	}
	
	// Method called to deserialize a Vector3 object
	public System.Object SetObjectData(System.Object obj,
	                                   SerializationInfo info, StreamingContext context,
	                                   ISurrogateSelector selector) {
		
		Vector3 v3 = (Vector3) obj;
		v3.x = (float)info.GetValue("x", typeof(float));
		v3.y = (float)info.GetValue("y", typeof(float));
		v3.z = (float)info.GetValue("z", typeof(float));
		obj = v3;
		return obj;   // Formatters ignore this return value //Seems to have been fixed!
	}
}

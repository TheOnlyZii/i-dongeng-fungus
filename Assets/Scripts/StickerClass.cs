using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;


[System.Serializable]
public class StickerClass {

	//public static StickerClass current;

	//public GameObject sticker;
	//public Vector3 position;
	//public Quaternion rotation;
	//public Vector3 scaleLocal;
	public string stickerName;

	private WB_Quart _rotation;
	public Quaternion rotation {
		get {
//			if (_rotation == null) {
//				return _rotation;
//			} else {
				return (Quaternion)_rotation;
			//}
		}
		set {
			_rotation = (WB_Quart)value;
		}
	}

	private WB_Vector3 _position;
	public Vector3 position {
		get {
			if (_position == null) {
				return Vector3.zero;
			} else {
				return (Vector3)_position;
			}
		}
		set {
			_position = (WB_Vector3)value;
		}
	}

	private WB_Vector3 _scaleLocal;
	public Vector3 scaleLocal {
		get {
			if (_scaleLocal == null) {
				return Vector3.zero;
			} else {
				return (Vector3)_scaleLocal;
			}
		}
		set {
			_scaleLocal = (WB_Vector3)value;
		}
	}
}

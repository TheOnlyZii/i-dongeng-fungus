using UnityEngine;
using System.Collections;

[System.Serializable]
public class WB_Quart {

	private float x;
	private float y;
	private float z;
	private float w;
	
	public WB_Quart() { }
	public WB_Quart(Quaternion vec3) {
		this.x = vec3.x;
		this.y = vec3.y;
		this.z = vec3.z;
		this.w = vec3.w;
	}
	
	public static implicit operator WB_Quart(Quaternion vec3) {
		return new WB_Quart(vec3);
	}
	public static explicit operator Quaternion(WB_Quart wb_vec3) {
		return new Quaternion(wb_vec3.x, wb_vec3.y, wb_vec3.z, wb_vec3.w);
	}
}

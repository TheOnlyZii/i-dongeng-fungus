using UnityEngine;
using System.Collections;

public class rotateController : MonoBehaviour {

	Vector3 mousePos;
	float distance;
	float curDistance;
	public bool rotate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		rotate = true;
		curDistance = Vector2.Distance(transform.parent.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}

	void OnMouseUp()
	{
		rotate = false;
	}
	
	void OnMouseDrag()
	{
		rotateSticker ();
		resizeSticker ();
	}

	void rotateSticker()
	{
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.parent.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position);
	}

	void resizeSticker()
	{
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		distance = Vector2.Distance (transform.parent.position, mousePos);

		Debug.Log ("distance : " + distance);
		Debug.Log ("current distance : " + curDistance);

		if(distance > curDistance)
		{
			transform.parent.localScale += new Vector3(0.025f, 0.025f, 0f);
			curDistance = distance;
		}
		if(distance < curDistance)
		{
			transform.parent.localScale -= new Vector3(0.025f, 0.025f, 0f);
			curDistance = distance;
		}
	}


}

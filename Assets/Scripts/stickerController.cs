using UnityEngine;
using System.Collections;

public class stickerController : MonoBehaviour {

	float x, y;
	private Vector3 screenPoint;
	private Vector3 offset;
	public GameObject circleRotate;

	public bool selected = false;
	public bool dragged = false;
	static private Transform trselect = null;
	
	stickerManager stickMan;
	rotateController rotateControl;
	
	public int sortingOrder = 0;
	private SpriteRenderer sprite;

	void Awake()
	{
	}

	// Use this for initialization
	void Start () {
		stickMan = GameObject.Find("stickerManager").GetComponent<stickerManager> ();
		rotateControl = GetComponentInChildren<rotateController> ();

		sprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

//		if(Application.loadedLevelName == "tempelSticker")
//		{
//			gameObject.SetActive(true);
//		}
//		else
//		{
//			gameObject.SetActive(false);
//		}

//		x = Input.GetTouch(0).position.x;
//		y = Input.GetTouch(0).position.y;

		if (dragged && this.gameObject.tag == "sticker") {
			foreach (Touch touch in Input.touches) {
				Vector3 touchPos;
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit;

				switch (touch.phase) {
				case TouchPhase.Began:

					touchPos = Camera.main.ScreenToWorldPoint (new Vector3 (touch.position.x, touch.position.y, screenPoint.z));
					offset = gameObject.transform.position - touchPos;

					break;
				case TouchPhase.Moved:
					if (this.gameObject.transform == trselect && selected == true) {
						touchPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
						gameObject.transform.position = touchPos + offset;
					}
					break;
				case TouchPhase.Ended:
					dragged = false;
					break;
				}
			}
		}
		
		if(selected && transform != trselect)
		{
			selected = false;
		}
		
		if(selected)
		{
			circleRotate.SetActive(true);
			sprite.sortingOrder = 1;
		}
		else
		{
			circleRotate.SetActive(false);
			sprite.sortingOrder = sortingOrder;
		}

		if(selected == true && stickMan.deleteFlag == true)
		{
			Destroy(trselect.gameObject);
			stickMan.deleteFlag = false;
			selected = false;
		}
	}

	void OnMouseDown()
	{
//		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(x, y, screenPoint.z));
//		if (selected)
//			selected = false;
//		else
//			selected = true;
		selected = true;
		trselect = transform;
		dragged = true;
	}

//	void OnMouseDrag()
//	{
//		Vector3 curScreenPoint = new Vector3 (x, y, screenPoint.z);
//		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
//		transform.position = curPosition;
//	}
}

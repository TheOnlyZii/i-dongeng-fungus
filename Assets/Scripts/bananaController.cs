using UnityEngine;
using System.Collections;

public class bananaController : MonoBehaviour {

	float x, y;
	private Vector3 screenPoint;
	private Vector3 offset;
	public bool selected = false;
	public bool dragged = false;
	static private Transform trselect = null;

	gMcocokGambar gmGambar;
	public GameObject gameManager;
	public GameObject[] tandaPanah;
	public GameObject[] pisang;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("gameManager");
		gmGambar = gameManager.GetComponent<gMcocokGambar>();
	}
	
	// Update is called once per frame
	void Update () {

//		x = Input.mousePosition.x;
//		y = Input.mousePosition.y;

		if (dragged) {
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

	}

	void OnMouseDown()
	{
		//offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(x, y , screenPoint.z));
		selected = true;
		trselect = transform;
		dragged = true;
	}
	
	void OnMouseDrag()
	{
//		Vector3 curScreenPoint = new Vector3 (x, y, screenPoint.z);
//		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
//		transform.position = curPosition;
	}

	void OnMouseUp()
	{
		if(this.gameObject.tag == "pisang1")
		{
			this.transform.position = new Vector2(-10.79f, -4.4f);
		}
		if(this.gameObject.tag == "pisang2")
		{
			this.transform.position = new Vector2(-4.07f, -4.4f);
		}
		if(this.gameObject.tag == "pisang3")
		{
			this.transform.position = new Vector2(3.46f, -4.4f);
		}
		if(this.gameObject.tag == "pisang4")
		{
			this.transform.position = new Vector2(10.315f, -4.4f);
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "tigis" && this.gameObject.tag == "pisang1") 
		{
			Debug.Log("triggered");
			gmGambar.nomorPisang[0].SetActive(true);
			gmGambar.tandaPanah[0].SetActive(false);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gmGambar.pisangDone[0] = true;
		}
		if (other.gameObject.tag == "galia" && this.gameObject.tag == "pisang2") 
		{
			Debug.Log("triggered");
			gmGambar.nomorPisang[1].SetActive(true);
			gmGambar.tandaPanah[1].SetActive(false);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gmGambar.pisangDone[1] = true;
		}
		if (other.gameObject.tag == "asa" && this.gameObject.tag == "pisang3") 
		{
			Debug.Log("triggered");
			gmGambar.nomorPisang[2].SetActive(true);
			gmGambar.tandaPanah[2].SetActive(false);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gmGambar.pisangDone[2] = true;
		}
		if (other.gameObject.tag == "tole" && this.gameObject.tag == "pisang4") 
		{
			Debug.Log("triggered");
			gmGambar.nomorPisang[3].SetActive(true);
			gmGambar.tandaPanah[3].SetActive(false);
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gmGambar.pisangDone[3] = true;
		}
	}
}

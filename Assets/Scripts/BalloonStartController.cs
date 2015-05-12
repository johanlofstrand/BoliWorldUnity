using UnityEngine;
using System.Collections;

public class BalloonStartController : MonoBehaviour {

	public Camera cam;
	public GameObject balloon;
	public GUIText Score;
	public int scoreCounter;
	private float maxWidth;
	private float balloonWidth;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main; 		
		}
		Vector3 upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint (upperCorner);
		balloonWidth = balloon.GetComponent<Renderer>().bounds.extents.x;
		maxWidth = targetWidth.x - balloonWidth;
		scoreCounter = 0;
	}

	void OnLeftClick(){
		Debug.Log ("Left click!");
		createNewBalloons ();
	}

	void createNewBalloons() {
		Instantiate(balloon);
		Vector3 pos = balloon.transform.position;
		pos.x = Random.Range (-maxWidth,maxWidth);
		balloon.transform.position = pos;
	}

	void OnRightClick(){
		Debug.Log ("Right click!");
	}

	public void updateScore() {
		scoreCounter++;
	}

	// Update is called once per frame
	void Update () {
		Score.text = "Score: " + scoreCounter;
	}
}

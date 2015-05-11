using UnityEngine;
using System.Collections;

public class BalloonStartController : MonoBehaviour {

	public Camera cam;
	public GameObject sprite;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main; 		
		}
//		GameObject gameControllerObject = GameObject.FindWithTag ("score");
//		Debug.Log (gameControllerObject);
	}

	void OnLeftClick(){
		Debug.Log ("Left click!");
		createNewBalloons ();
	}

	void createNewBalloons() {
		GameObject balloonObject = GameObject.Instantiate(Resources.Load("blue")) as GameObject;
		balloonObject.transform.position = new Vector3(Random.Range (-5,5),0,0);
	}

	void OnRightClick(){
		Debug.Log ("Right click!");
	}

	// Update is called once per frame
	void Update () {
	}
}

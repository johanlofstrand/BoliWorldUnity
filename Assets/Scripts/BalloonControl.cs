 using UnityEngine;
using System.Collections;

public class BalloonControl : MonoBehaviour {

	public Camera cam;
	public GameObject sprite;

	// Use this for initialization
	void Start () {
		if (cam == null) {
			cam = Camera.main; 		
		}
	}

	void OnLeftClick(){
		Debug.Log ("Left click!");
		createNewBalloons ();
	}

	void createNewBalloons() {
		Sprite grey_balloon = Resources.Load("grey", typeof(Sprite)) as Sprite;
		Vector3 position = new Vector3 (10, 10, 0);
		//transform.position = position;
	}


	void OnRightClick(){
		Debug.Log ("Right click!");
	}

	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonDown (0)) {
			Debug.Log("X:" + Input.mousePosition.x);
			Debug.Log("Y:" + Input.mousePosition.y);
		}*/
		//PolygonCollider2D hitCollider = Physics2D.IsTouching();
		//Collider2D hitCollider = Physics2D.OverlapPoint(Input.mousePosition);
		//if(hitCollider){
		//	Debug.Log("hit: " + hitCollider);
			//sprite.transform.position.x = hitCollider.transform.position.x;
			//sprite.transform.position.y = hitCollider.transform.position.y;    
			//Debug.Log("Hit "+hitCollider.gameObject.name+" x"+hitCollider.gameObject.position.x+" y "+hitCollider.gameObject.position.y);    
		//}
	}
}

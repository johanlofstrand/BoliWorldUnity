using UnityEngine;
using System.Collections;

public class BalloonController : MonoBehaviour {

	Sprite pop;
	float vx = 0.01f;
	float direction = 1f;
	BalloonStartController gameController;

	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <BalloonStartController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
		pop = Resources.Load <Sprite> ("blue_pop");
		direction = rightOrLeft();
	}

	void OnLeftClick(){
		gameController.updateScore ();
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); 
		spriteRenderer.sprite = pop; 
		AudioSource sound = gameObject.GetComponent<AudioSource>();
		sound.Play();
		StartCoroutine (WaitPop());
	}

	IEnumerator WaitPop()
	{
		yield return new WaitForSeconds(0.6f);
		Destroy(this.gameObject);
	}
	
	void Update () {
		var pos = this.gameObject.transform.position;
		pos.x += vx * direction;
		this.gameObject.transform.position = pos;
	}

	int rightOrLeft() {
		return Random.value > 0.5 ? -1 : 1;
	}


	/*
	  public class BalloonController (){
     static public GameObject MakeObject(String balloonColor){
         GameObject clone = (GameObject)Instantiate(playerPrefab);
         clone.GetComponent<Controller>().balloonColor = balloonColor;
         return clone;
     }
 }*/

}

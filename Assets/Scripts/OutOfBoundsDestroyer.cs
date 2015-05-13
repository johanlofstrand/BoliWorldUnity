using UnityEngine;
using System.Collections;

public class OutOfBoundsDestroyer : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D obj) {
		Debug.Log ("Destroyed balloon that's out of bounds: " + obj.gameObject.name);
		Destroy (obj.gameObject);
	}
}

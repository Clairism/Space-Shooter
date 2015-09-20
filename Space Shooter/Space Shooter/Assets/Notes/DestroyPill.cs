using UnityEngine;
using System.Collections;

public class DestroyPill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider otherObject) {
		if ( otherObject.gameObject.tag == "pill" ){
			Destroy (otherObject.gameObject);

		}
	}
}

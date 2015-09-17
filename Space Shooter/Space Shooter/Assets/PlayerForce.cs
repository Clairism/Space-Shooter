using UnityEngine;
using System.Collections;

public class PlayerForce : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey(KeyCode.W)){

			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 30);

		}

		if ( Input.GetKey(KeyCode.A)){
			
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * 30);
			
		}

		if ( Input.GetKey(KeyCode.D)){
			
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 30);

		}

		if ( Input.GetKey(KeyCode.S)){
			
			gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * 30);
			
		}
	
	}
}

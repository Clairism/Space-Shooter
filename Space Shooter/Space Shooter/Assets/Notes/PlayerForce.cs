using UnityEngine;
using System.Collections;

public class PlayerForce : MonoBehaviour {
	public float speed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Rigidbody bullet = GetComponent<Rigidbody> ();

		Input.GetAxis ("Horizontal");
		bullet.AddForce ( new Vector3 ( speed * Time.deltaTime, 0, 0) * Input.GetAxis ("Horizontal") );


		Input.GetAxis ("Vertical");
		bullet.AddForce ( new Vector3 (0, speed * Time.deltaTime, 0) * Input.GetAxis ("Vertical"));

	}
}

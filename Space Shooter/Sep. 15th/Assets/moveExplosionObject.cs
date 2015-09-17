using UnityEngine;
using System.Collections;

public class moveExplosionObject : MonoBehaviour {
	private float speed = 5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//move up through the scene
		//transform.position = transform.position + a little up
		transform.position = transform.position + Vector3.up * speed * Time.deltaTime;

		//                                        direction    unit(s)   per second   
	}
}

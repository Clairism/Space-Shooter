using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject fireworkToSpawn;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetKey(KeyCode.LeftShift)) {
			Instantiate ( fireworkToSpawn, transform.position, transform.rotation );
		}

	
	}
}

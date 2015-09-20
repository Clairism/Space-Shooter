using UnityEngine;
using System.Collections;

public class MakeASphere : MonoBehaviour {

	public GameObject pillToSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( Input.GetKey(KeyCode.G)) {
			Instantiate ( pillToSpawn, transform.position, transform.rotation );
	}


		//GetKeyDown  [just once]
			//GetKeyUp
  }
}

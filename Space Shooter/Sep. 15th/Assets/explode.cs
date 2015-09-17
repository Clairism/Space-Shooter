using UnityEngine;
using System.Collections;

public class explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GetComponent<Rigidbody>().AddForce( Random.insideUnitSphere *1000);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

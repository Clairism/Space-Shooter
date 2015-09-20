using UnityEngine;
using System.Collections;

public class RandomDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitCircle * 1000);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

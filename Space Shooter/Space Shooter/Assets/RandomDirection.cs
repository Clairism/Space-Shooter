﻿using UnityEngine;
using System.Collections;

public class RandomDirection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody> ().AddForce (Random.insideUnitCircle * 1000);

		GetComponent<Rigidbody> ().AddForce ( new Vector3 ( Random.Range(-1000, 1000), Random.Range(-1000, 1000), 0 ));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

﻿using UnityEngine;
using System.Collections;

public class DestroyAfterParticle : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Destroy (gameObject, gameObject.GetComponent<ParticleSystem>().duration);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

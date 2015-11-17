using UnityEngine;
using System.Collections;

public class DestroyAfterSpawn : MonoBehaviour {

 void OnTriggerEnter(Collider otherObject) {

		//GetComponent<ParticleSystem> ().enabled = true;
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class TargetTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider otherObject){

		if (otherObject.gameObject.tag == "Bullet") {
			Application.LoadLevel ("Game Over");
		}

	}

}

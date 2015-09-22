using UnityEngine;
using System.Collections;

public class ShootRandom : MonoBehaviour {
	public GameObject shootingObject;
	private bool canshoot;

	// Use this for initialization
	void Start () {

		canshoot = true;
	
	}

	void SpawnIt() {
		Instantiate (shootingObject, transform.position, transform.rotation);

		canshoot = false;
		Invoke ("turnOnShooter", Random.Range(.5f, 4f));
	}

	void turnOnShooter() {
		canshoot = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (canshoot == true) {
			SpawnIt();
		}
	
	}
}

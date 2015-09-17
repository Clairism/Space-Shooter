using UnityEngine;
using System.Collections;

public class spawnExplosionObjects : MonoBehaviour {
	public GameObject expObject;
	private bool canShoot;
	// Use this for initialization
	void Start () {

		canShoot = true;
	//	InvokeRepeating  ("shootAuto", .3f, 1.5f)
	
	}

	void SpawnAnObject() {

		Instantiate(expObject, transform.position, transform.rotation);

		canShoot = false;
		Invoke ("turnOnShooter", .3f);
	}
	

	void turnOnShooter() {
		canShoot = true;
	}

	void Update () {

		if ( Input.GetKey(KeyCode.Space )) {
			if (canShoot == true){
				SpawnAnObject();
			}
		}
	}

//	void ShootAuto(){
//		Instantiate (expObject, transform.position, transform.rotation);
//	}

}

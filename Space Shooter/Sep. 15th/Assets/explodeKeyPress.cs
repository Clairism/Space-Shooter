using UnityEngine;
using System.Collections;

public class explodeKeyPress : MonoBehaviour {

	public GameObject Explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( Input.GetKey(KeyCode.LeftShift)) {
			Destroy(gameObject);
		}
	}

	void OnDestroy() {
		Instantiate( Explosion, transform.position, transform.rotation);
	}
}

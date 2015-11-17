using UnityEngine;
using System.Collections;

public class RandomDirection : MonoBehaviour {

	//private float x;
	//private float y;


	// Use this for initialization
	void Start () {

	//	x = Random.Range(-700, 700);
	//	y = Random.Range(-700, 700);

		//GetComponent<Rigidbody> ().AddForce ( new Vector3 ( x, y, 0 ));
		GetComponent<Rigidbody>().AddForce( Random.insideUnitCircle * 300);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

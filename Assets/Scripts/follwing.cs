using UnityEngine;
using System.Collections;

public class follwing : MonoBehaviour {

	public GameObject target;
	public GameObject light;



	public bool turnon;

	void Start () {

		turnon = false;

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (target.transform.position.x + 5, target.transform.position.y + 4, target.transform.position.z);
		if (!turnon) {
			light.gameObject.SetActive (false);
		} else {

			light.gameObject.SetActive(true);

		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "ava") {
			turnon=true;
		}
	}
}

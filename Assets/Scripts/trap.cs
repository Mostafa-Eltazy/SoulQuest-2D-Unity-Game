using UnityEngine;
using System.Collections;

public class trap : MonoBehaviour {

	// Use this for initialization
	public Transform x;
	public GameObject magic;

	public GameObject avian;

	public int noavian;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){

		if(other.tag=="player"){
			magic.gameObject.SetActive(true);
			for(int i=0;i<noavian;i++){
			Instantiate(avian,x.transform.position,x.transform.rotation);
		}
			magic.gameObject.SetActive(false);
			gameObject.SetActive (false);
		}

	}
}

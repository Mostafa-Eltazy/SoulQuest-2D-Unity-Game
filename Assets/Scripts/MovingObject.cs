using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

	public GameObject ObjectToMove;

	public Transform startpoint;
	public Transform endpoint;
	public float movespeed;
	private Vector3 currenttarget;
	public bool collisionhappened = false;

	// Use this for initialization
	void Start () {

		currenttarget = endpoint.position;
	}
	
	// Update is called once per frame
	void Update () {
	

		


	
	}

		void OnCollisionEnter2D(Collision2D other) {
			collisionhappened=true;
			ObjectToMove.transform.position = Vector3.MoveTowards (ObjectToMove.transform.position, currenttarget, movespeed * Time.deltaTime);
		}

}

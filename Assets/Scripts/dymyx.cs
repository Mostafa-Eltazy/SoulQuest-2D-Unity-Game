using UnityEngine;
using System.Collections;

public class dymyx : WalkingEnemy {

	public GameObject battle;
	// Use this for initialization
	void Start () {
	

	}
	

	void Update () {
			
		if (Health <= 0) {
			battle.SetActive(false);
		}
	}
}

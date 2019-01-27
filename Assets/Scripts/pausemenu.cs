using UnityEngine;
using System.Collections;

public class pausemenu : MonoBehaviour {

	// Use this for initialization
	public GameObject thepausescreen;
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			thepausescreen.SetActive(true);
		}
	}
	public void resumegame(){

		thepausescreen.SetActive (false);
	}
	public void returntomanimenu(){

		Application.LoadLevel ("");//write the name of the main menue scene 
	}
}

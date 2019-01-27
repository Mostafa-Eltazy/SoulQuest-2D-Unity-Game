using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void newgame() {
		
		Application.LoadLevel("forestmorning");
	}
	public void quit() {
		
		Application.Quit ();
	}
}

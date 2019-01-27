using UnityEngine;
using System.Collections;

public class mainmenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void newgame() {

        Application.LoadLevel("");
    }
    void quitgame() {

        Application.Quit();
    }
}

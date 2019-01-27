using UnityEngine;
using System.Collections;

public class ColorButton : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void TriggerButton()
	{
		if (this.tag == "Red")
			FindObjectOfType<PlayerStats>().red++;
		else if (this.tag == "Yellow") 
			FindObjectOfType<PlayerStats>().yellow++;
		else if (this.tag == "White")
			FindObjectOfType<PlayerStats>().white++;
		else if (this.tag == "Blue")
			FindObjectOfType<PlayerStats>().blue++;
		
		FindObjectOfType<DialogueManager>().buttonPress = true;
		
	}
}

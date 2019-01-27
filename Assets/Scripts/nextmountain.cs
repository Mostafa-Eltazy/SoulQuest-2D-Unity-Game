using UnityEngine;
using System.Collections;

public class nextmountain : MonoBehaviour {

	// Use intthis for initialization
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "player") {

			PlayerPrefs.SetInt("redpoints",FindObjectOfType<PlayerStats>().red);
			PlayerPrefs.SetInt("yellowpoints",FindObjectOfType<PlayerStats>().yellow);
			PlayerPrefs.SetInt("whitepoints",FindObjectOfType<PlayerStats>().white);
			PlayerPrefs.SetInt("bluepoints",FindObjectOfType<PlayerStats>().blue);
			PlayerPrefs.SetInt("healthpoints",FindObjectOfType<PlayerStats>().health);
			PlayerPrefs.SetInt("lives",FindObjectOfType<PlayerStats>().lives);
			Application.LoadLevel ("mountain");
			
		}
	}
}

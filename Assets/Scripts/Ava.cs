using UnityEngine;
using System.Collections;

public class Ava : MonoBehaviour {
	private SpriteRenderer therenderer;
	
	private DialogueManager manager;
	[TextArea(3, 10)]
	public string[] dialogueLines;
	public string[] buttonText;
	
	
	// Use this for initialization
	void Start () {
		therenderer = GetComponent<SpriteRenderer>();
		therenderer.enabled = false;
		manager = FindObjectOfType<DialogueManager>();
		
	}
	
	// Update is called once per frame
	void Update () {  
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "player")
		{
			therenderer.enabled = true;
			manager.holder = this;
			if (!manager.dialogActive)
			{
				manager.dialogLines = dialogueLines;
				manager.buttonOptions = buttonText;
				manager.currentLine = 0;
				manager.showDialogue();
			}
		}
	}
	
	public void destroy()
	{
		Destroy(this.gameObject);
	}
}

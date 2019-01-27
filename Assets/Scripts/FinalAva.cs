using UnityEngine;
using System.Collections;

public class FinalAva : MonoBehaviour {

	private SpriteRenderer therenderer;
	public string max;
	
	private DialogueManager manager;
	[TextArea(3, 10)]
	public string[] RedDialogueLines;
	public string[] WhiteDialogueLines;
	public string[] BlueDialogueLines;
	public string[] YellowDialogueLines;
	
	private PlayerStats player;
	
	// Use this for initialization
	void Start()
	{
		therenderer = GetComponent<SpriteRenderer>();
		therenderer.enabled = false;
		manager = FindObjectOfType<DialogueManager>();
		player = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "player")
		{
			therenderer.enabled = true;
			manager.finalAva = true;
			max=player.FindMax();
			
			if (!manager.dialogActive)
			{
				if (max == "red")
					manager.dialogLines = RedDialogueLines;
				else if (max == "yellow")
					manager.dialogLines = YellowDialogueLines;
				else if (max == "white")
					manager.dialogLines = WhiteDialogueLines;
				else if (max == "blue")
					manager.dialogLines = BlueDialogueLines;
				
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

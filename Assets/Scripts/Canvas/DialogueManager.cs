using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	public GameObject dBox;
	public Text dText;
	public Text dContinue;
	public Text[] buttons;
	public Button b1,b2,b3,b4;
	
	public KeyCode down;
	
	public bool dialogActive;
	[TextArea(3, 10)]
	public string[] dialogLines;
	public string[] buttonOptions;
	public int currentLine;
	
	public bool buttonPress;
	
	private Mainplayer player;
	public Ava holder;
	private FinalAva holder2;
	
	public bool finalAva;
	
	// Use this for initialization
	void Start()
	{
		player = FindObjectOfType<Mainplayer>();
		b1.gameObject.SetActive(false);
		b2.gameObject.SetActive(false);
		b3.gameObject.SetActive(false);
		b4.gameObject.SetActive(false);
		
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (!finalAva)
		{
			if (dialogActive && Input.GetKeyDown(down) && currentLine < dialogLines.Length - 1)
			{
				currentLine++;
			}
			
			if (dialogActive && currentLine == dialogLines.Length - 1 && buttonPress)
			{
				currentLine++;
			}
		}
		if (finalAva && dialogActive && Input.GetKeyDown(down))
		{
			currentLine++;
		}
		if (currentLine >= dialogLines.Length)
		{
			dBox.SetActive(false);
			dialogActive = false;
			currentLine = 0;
			player.canMove = true;
			buttonPress = false;
			b1.gameObject.SetActive(false);
			b2.gameObject.SetActive(false);
			b3.gameObject.SetActive(false);
			b4.gameObject.SetActive(false);
			if (!finalAva)
				holder.destroy();
			else
				holder2.destroy();
		}
		
		dText.text = dialogLines[currentLine];
		if (!finalAva)
		{
			if (currentLine == dialogLines.Length - 1)
			{
				for (int i = 0; i < 4; i++)
				{
					buttons[i].text = buttonOptions[i];
				}
				b1.gameObject.SetActive(true);
				b2.gameObject.SetActive(true);
				b3.gameObject.SetActive(true);
				b4.gameObject.SetActive(true);
				dContinue.gameObject.SetActive(false);
			}
		}
	}
	
	public void showDialogue()
	{
		if(finalAva)
			holder2 = FindObjectOfType<FinalAva>();
		dialogActive = true;
		dBox.SetActive(true);
		dContinue.gameObject.SetActive(true);
		player.canMove = false;
	}
}

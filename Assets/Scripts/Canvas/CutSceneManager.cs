using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CutSceneManager : MonoBehaviour {
    //public GameObject dBox;
    public Text dText;

    
    public KeyCode down;
    public KeyCode skip;

   // public bool dialogActive;
    [TextArea(3, 10)]
    public string[] dialogLines;
    public int currentLine;

    // Use this for initialization
    void Start()
    {
        dText.text = dialogLines[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
   
            if ( Input.GetKeyDown(down))
            {
                currentLine++;
            }

            if (Input.GetKeyDown(skip))
            {
                currentLine = dialogLines.Length;
            }

        if (currentLine >= dialogLines.Length)
        {
           
        }

        dText.text = dialogLines[currentLine];
       
       
    }


}

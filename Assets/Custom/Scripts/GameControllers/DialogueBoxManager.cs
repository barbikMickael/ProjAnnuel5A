using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DialogueBoxManager : MonoBehaviour {

    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    public string[] textLines;
    public GestionEmotion playerEMotion;
    public int currentLine;
    public int endAtLine;
    public float timer;

    // Use this for initialization
    void Start () {
        if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        if (endAtLine == 0)
        {
           endAtLine = textLines.Length - 1;
        }
        theText.text = textLines[currentLine];
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.D))
        {
            NextDialogue();
        }
            
	}

    public void ButtonCharmPressed()
    {
       
        StartCoroutine(DialogueTimer());
    }
        
    IEnumerator DialogueTimer()
    {  
         
        yield return new WaitForSeconds(timer);
        NextDialogue();
    }

    void NextDialogue()
    {
        // arbres de dialogues
        if (playerEMotion.GetEmotion()<8)
        {
            if (currentLine < endAtLine)
            {
                currentLine += 2;
            }
        }
        else if (playerEMotion.GetEmotion() > 13)
        {
            if (currentLine < endAtLine)
            {
                currentLine += 1;
            }
        }


        theText.text = textLines[currentLine];

    }
}

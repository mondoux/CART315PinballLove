using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogeManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;

    private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue <string>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Start convrsation with" + dialogue.name);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {

            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();



    }

    public void DisplayNextSentence()
    {
    if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }
    void EndDialogue ()
    {
        Debug.Log("End of onversation");

    }
}

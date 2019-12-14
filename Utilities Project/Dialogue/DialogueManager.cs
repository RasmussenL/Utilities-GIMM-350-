﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;

    public GameObject dialogueBox;

    public Text nameText;
    public Text dialogueText;

    private Queue<string> sentences;
    void Awake()
    {
        Instance = this;
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting a conversation with " + dialogue.name);
        dialogueBox.SetActive(true);
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
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
        /*nameText.text = "done";
        dialogueText.text = "done";*/
        dialogueBox.SetActive(false);
    }
}

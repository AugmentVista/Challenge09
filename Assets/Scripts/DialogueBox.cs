using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class DialogueBox : MonoBehaviour
{
    TMP_Text ScreenText;
    Image BackgroundPanel;
    Queue<string> TextQueue = new Queue<string>();
    InteractionObject CurrentObject;
    void Start()
    {
        ScreenText = GetComponentInChildren<TMP_Text>();
        BackgroundPanel = GetComponentInChildren<Image>();
        BackgroundPanel.enabled = false;
    }
    void Update()
    {
        if (GlobalVariables.isTalking && Input.GetKeyDown("e"))
        {
            NextLine();
        }
    }
    public void SecondQueue(List<string> SecondDialogue)
    {
        TextQueue.Clear();
        foreach (string SecondDialogueItem in SecondDialogue)
        {
            TextQueue.Enqueue(SecondDialogueItem);
        }
        BackgroundPanel.enabled = true;
        NextLine();
    }
    public void FillQueue(List<string> dialogue, InteractionObject interactionObj)
    {
        CurrentObject = interactionObj;
        TextQueue.Clear();

        if (GlobalVariables.Thing2) // Thing2 is placeholder
        {
            CurrentObject.ThirdToFirst();
        }
        else if (GlobalVariables.Thing3) // Thing3 is placeholder
        {
            CurrentObject.SecondToFirst();
        }

        foreach (string dialogueItem in dialogue)
        {
            TextQueue.Enqueue(dialogueItem);
        }
        BackgroundPanel.enabled = true;
        GlobalVariables.isTalking = true;
        NextLine();
    }
    void NextLine()
    {
        if (TextQueue.Count > 0)
        {
            ScreenText.text = TextQueue.Dequeue();
        }
        else if (TextQueue.Count == 0)
        {
            ScreenText.text = "";
            GlobalVariables.isTalking = false;
            BackgroundPanel.enabled = false;
        }
    }
}
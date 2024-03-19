using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public enum Types
    {
        nothing, pickup, info, dialogue,
    }
    public Types type;

    public string infoText; // Add a reference to text in game called Gameplay Info and InfoText
    public List<string> dialogue;
    public List<string> SecondDialogue;
    public List<string> ThirdDialogue;
    Info info;
    DialogueBox dialogueBox;
    void Start()
    {
        info = FindObjectOfType<Info>();
        dialogueBox = FindObjectOfType<DialogueBox>();
    }
    public void Interact()
    {
        switch (type)
        {
            case Types.nothing:
                Nothing();
                break;
            case Types.pickup:
                Pickup();
                break;
            case Types.info:
                Info();
                break;
            case Types.dialogue:
                Dialogue();
                break;
        }
    }
    void Nothing()
    {
        Debug.Log("Empty");
    }
    void Pickup()
    {
        Debug.Log("Pickup");
        gameObject.SetActive(false);
    }
    void Info()
    {
        Debug.Log("Info Display");
        //info.SetText(infoText);
    }
    void Dialogue()
    {
        Debug.Log("Dialogue registering");
        //dialogueBox.FillQueue(dialogue, this);
    }
    public void SecondToFirst()
    {
        dialogue.Clear();
        foreach (string line in SecondDialogue)
        {
            dialogue.Add(line);
        }
    }
    public void ThirdToFirst()
    {
        dialogue.Clear();
        foreach (string line in ThirdDialogue)
        {
            dialogue.Add(line);
        }
    }
}
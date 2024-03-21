using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]
    GameObject CurrentObject;
    void Update()
    {
        if (!GlobalVariables.isTalking && Input.GetKeyDown("space"))
        {
            playerInteract();
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer < 15)
        {
            CurrentObject = collision.gameObject;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer < 15)
        {
            CurrentObject = null;
        }
    }
    public void playerInteract()
    {
        if (CurrentObject != null)
            CurrentObject.GetComponent<InteractionObject>().Interact();
    }
}

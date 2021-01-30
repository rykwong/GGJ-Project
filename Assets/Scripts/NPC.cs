using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Update()
    {
        if (Input.GetKey("e") && Vector2.Distance(transform.position, player.transform.position) < 1)
        {
            TriggerDialogue();
        }
    }
}

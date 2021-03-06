﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    private GameObject player;
    public string quest;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }
    public void TriggerDialogue()
    {
        if (PlayerPrefs.GetInt(quest) == 0)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }

    public void Update()
    {
        if (Input.GetKey("e") && Vector2.Distance(transform.position, player.transform.position) < 3f)
        {
            TriggerDialogue();
        }
        //Debug.Log(Vector2.Distance(transform.position, player.transform.position));
    }
}

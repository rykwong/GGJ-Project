using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public Text name;
    public Text dialogue;
    public Animator animator;
    public Button[] choices;
    public Button cont;
    private bool hasChoice = true;
    private bool isDialogue = false;

    
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue)
    {
        isDialogue = true;
        //Debug.Log("Starting conversatino with " + dialogue.name);
        animator.SetBool("IsOpen", true);
        name.text = dialogue.name;
        sentences.Clear();

        if (dialogue.choices.Length == 0)
        {
            hasChoice = false;
        }
        else
        {
            hasChoice = true;
        }
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        cont.gameObject.SetActive(true);
        foreach (Button choice in choices)
        {
            choice.gameObject.SetActive(false);
        }
        
        for(int i = 0; i < dialogue.choices.Length; i ++ )
        {
            choices[i].GetComponentInChildren<Text>().text = dialogue.choices[i];
        }
        DisplayNext();
    }

    public void DisplayNext()
    {
        if (sentences.Count == 0)
        {
            if (hasChoice)
            {
                ShowChoices();
            }
            else
            {
                EndDialogue();
            }
            cont.gameObject.SetActive(false);
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogue.text = sentence;
        //Debug.Log(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogue.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogue.text += letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {
        isDialogue = false;
        if(animator.GetBool("IsOpen"))
        {
            Debug.Log("End Conversation");
            animator.SetBool("IsOpen", false);
        }
    }

    public void ShowChoices()
    {
        foreach (Button choice in choices)
        {
            choice.gameObject.SetActive(true);
        }
    }
}

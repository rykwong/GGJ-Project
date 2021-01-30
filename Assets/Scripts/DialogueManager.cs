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

    
    void Start()
    {
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //Debug.Log("Starting conversatino with " + dialogue.name);
        animator.SetBool("IsOpen", true);
        name.text = dialogue.name;
        sentences.Clear();
        
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        
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
            ShowChoices();
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
        Debug.Log("End Conversation");
        animator.SetBool("IsOpen", false);
        
    }

    public void ShowChoices()
    {
        
        foreach (Button choice in choices)
        {
            choice.gameObject.SetActive(true);
        }
    }
}

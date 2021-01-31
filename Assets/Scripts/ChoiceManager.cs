using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    private DialogueManager dialogueManager;

    private QuestManager questManager;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
        questManager = FindObjectOfType<QuestManager>();

    }

    public void CheckChoice(GameObject gameObject)
    {
        string text = gameObject.GetComponentInChildren<Text>().text;

        dialogueManager.EndDialogue();
        if (text == "Find gas")
        {
            Debug.Log("You chose to get gas");
            questManager.TruckerQuest(1);
        }
        else if (text == "Pee on car")
        {
            Debug.Log("You chose to pee on him");
            questManager.TruckerQuest(2);
        }
        else if (text == "Deliver lunch")
        {
            Debug.Log("You chose to deliver lunch");
            questManager.OldLadyQuest(1);
        }
        else if (text == "Bark loudly")
        {
            Debug.Log("You chose to bark loudly");
            questManager.OldLadyQuest(2);
        }
        else if (text == "Do homework")
        {
            Debug.Log("You chose to help with homework");
            questManager.MathQuest();
        }
        
        
    }
}

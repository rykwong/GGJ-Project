using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject gas;
    public GameObject lunch;
    public GameObject player;
    public GameObject math;
    public Dialogue TruckerDialogue;

    public Dialogue OldLadyDialogue;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        player = GameObject.FindWithTag("Player");
    }

    public void TruckerQuest(int n)
    {
        if (n == 1)
        {
            gas.SetActive(true);
        }
        else
        {
            GameObject.Find("Trucker").GetComponent<NPC>().dialogue = TruckerDialogue;
            FindObjectOfType<DialogueManager>().StartDialogue(TruckerDialogue);
        }
    }

    public void OldLadyQuest(int n)
    {
        if (n == 1)
        {
            Vector2 temp = player.transform.position;
            temp.y += 10;
            lunch.transform.position = temp;
            lunch.SetActive(true);
        }
        else
        {
            GameObject.Find("Old Lady").GetComponent<NPC>().dialogue = OldLadyDialogue;
            FindObjectOfType<DialogueManager>().StartDialogue(OldLadyDialogue);
        }
    }

    public void MathQuest()
    {
        math.SetActive(true);
    }
}

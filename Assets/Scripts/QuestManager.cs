using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject gas;
    
    public Dialogue TruckerDialogue;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

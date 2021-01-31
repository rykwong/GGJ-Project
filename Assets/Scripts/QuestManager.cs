using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class QuestManager : MonoBehaviour
{
    public GameObject gas;
    public GameObject lunch;
    public GameObject player;
    public GameObject math;
    public GameObject speech;
    public Dialogue TruckerDialogue;

    public GameObject[] people;

    public Dialogue OldLadyDialogue;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        player = GameObject.FindWithTag("Player");

        foreach (GameObject person in people)
        {
            person.transform.position = new Vector2(Random.Range(-100, 50), -7);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("trucker") == 1 && PlayerPrefs.GetInt("oldlady") == 1 && PlayerPrefs.GetInt("math") == 1)
        {
            speech.SetActive(true);
        }

        if (Vector2.Distance(GameObject.Find("Owner").transform.position, player.transform.position) < 27)
        {
            speech.SetActive(false);
        }
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
            temp.y += 5;
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

    public void OwnerQuest()
    {
        SceneManager.LoadScene("Ending");
    }
}

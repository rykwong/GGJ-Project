﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MathManager : MonoBehaviour
{
    private Problem[] problems = new Problem[5];
    [SerializeField] private GameObject math;
    public InputField iField;
    public Text problemText;
    public int curProblem;
    [SerializeField] private Dialogue dialogue;
    void Start()
    {
        for(int i = 0; i < problems.Length; i ++){
            Problem temp = new Problem();
            temp.first = Random.Range(0, 100);
            temp.operation = Random.Range(0, 2) == 0 ? MathOperations.Addition : MathOperations.Subtraction;
            temp.second = temp.operation == MathOperations.Subtraction ? Random.Range(0, (int)temp.first) : Random.Range(0, 100);
            problems[i] = temp;
        }
        SetProblem(0);
    }


    private void Complete()
    {
        Debug.Log("Finished");
        NPC girl = GameObject.Find("Girl").GetComponent<NPC>();
        PlayerPrefs.SetInt(girl.quest,1);
        girl.dialogue = dialogue;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        math.SetActive(false);
    }
    private void SetProblem(int problem)
    {
        curProblem = problem;
        string operatorText = "";
        Problem expression = problems[curProblem];
        switch (expression.operation)
        {
            case MathOperations.Addition: 
                operatorText = " + ";
                expression.answer = expression.first + expression.second;
                break;
            case MathOperations.Subtraction: 
                operatorText = " - ";
                expression.answer = expression.first - expression.second;
                break;
        }
        Debug.Log(expression.first + operatorText + expression.second);
        problemText.text = expression.first + operatorText + expression.second;
        
    }

    private void Correct()
    {
        if (problems.Length - 1 == curProblem)
        {
            Complete();
        }
        else
        {
            SetProblem(curProblem + 1);
        }
    }

    public void CheckAnswer(string answer)
    {
        Debug.Log(answer);
        iField.text = "";
        int ans = int.Parse(answer);
        if (ans == problems[curProblem].answer)
        {
            Correct();
        }
        
    }
}

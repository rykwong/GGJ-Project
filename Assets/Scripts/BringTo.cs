﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringTo : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private string quest;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.transform.position) < 1)
        {
            Debug.Log("Brought the item to " + target.name);
            PlayerPrefs.SetInt(quest,1);
            Destroy(gameObject);
        }
    }
}
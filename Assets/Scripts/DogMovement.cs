using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogMovement : MonoBehaviour
{
    //private Rigidbody2D rb;

    public static string direction;

    private void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Translate(Vector3.right * Time.deltaTime);
            direction = "right";
        }  
         
        else if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Translate(Vector3.left * Time.deltaTime);
            direction = "left";
        }
        else
        {
            direction = "none";
        }
         

    }
}

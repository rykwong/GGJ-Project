using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float launchForce;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Trampoline"))
        {
            if (DogMovement.direction == "right")
            {
                Vector2 temp = rb.velocity;
                temp.x = Vector2.right.x *launchForce;
                rb.velocity = temp;
            }
            else if (DogMovement.direction == "left")
            {
                Vector2 temp = rb.velocity;
                temp.x = Vector2.left.x *launchForce;
                rb.velocity = temp;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;
	
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;


    // Update is called once per frame
    void Update()
    {
    	horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    	animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

    	if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
    	{
    		jump = true;
    		animator.SetBool("IsJumping", true);
    	}
    	if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
    	{
    		crouch = true;
    	}
    	else if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
    	{
    		crouch = false;
    	}
    }

    public void OnLanding()
    {
	    Debug.Log("Landing");
    	animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
    	// Move Character
    	controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
    	jump = false;
    }
}

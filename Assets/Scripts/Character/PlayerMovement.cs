using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.80f;
    public float JumpHeight = 4f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position,groundDistance, groundMask);

        if(isGrounded && velocity.y <0)
        {
            velocity.y= -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move (move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
           velocity.y = Mathf.Sqrt(JumpHeight * -2f * gravity);     
        }
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity*Time.deltaTime);

        if (Input.GetKeyDown (KeyCode.Alpha1)) {
            transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

        } else if (Input.GetKeyDown (KeyCode.Alpha2)) {

            transform.position = new Vector3 (transform.position.x, transform.position.y + 0.5f, transform.position.z);
            transform.localScale = new Vector3 (1.25f, 1.25f, 1.25f);
        } else if (Input.GetKeyDown (KeyCode.Alpha3)) {

            transform.position = new Vector3 (transform.position.x, transform.position.y + 1.0f, transform.position.z);
            transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
        }
 
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code was made following a toutorial on the youtube channel Brackeys
//the url is: 

public class PlayerMovement : MonoBehaviour {
    
    public CharacterController controller;
    private float speed = 15f;

    Vector3 velocity;
    private float gravity = -24.525f;

    public Transform groundCheck;
    private float groundDistance = .4f;
    public LayerMask groundMask;
    private bool isGrounded;
    public bool isAlive = true;

    private float jumpHeight = 3f;

    // Update is called once per frame
    void Update() {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * x) + (transform.forward * z);
        controller.Move(move * Time.deltaTime * speed);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}

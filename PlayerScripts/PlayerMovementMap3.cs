using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code was made following a toutorial on the youtube channel Brackeys
//the name of the video is: FIRST PERSON MOVEMENT in Unity - FPS Controller

//had to make a seperate player movement script for map3 because of the way I added the slow water feature

public class PlayerMovementMap3 : MonoBehaviour {
    
    //values of gravity and speed were adjusted from the tutorial to fit my preference
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
        //checks to see if the player is touching the ground so we know when we can jump again
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }

        //handles input for jumping with the spacebar
        if (Input.GetButtonDown("Jump") && isGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //handles input for WASD/movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //if the player is below the water level (therefore touching water) then slow the player down
        //found out this value by moving the player to the water
        if (gameObject.transform.position.y < 8.5f) {
            speed = 3f;
        } else {
            speed = 15f;
        }

        //actually moves the character
        Vector3 move = (transform.right * x) + (transform.forward * z);
        controller.Move(move * Time.deltaTime * speed);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}

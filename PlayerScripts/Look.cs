using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code was made following a toutorial on the youtube channel Brackeys
//the name of the video is: FIRST PERSON MOVEMENT in Unity - FPS Controller

public class Look : MonoBehaviour {

public float mouseSens = 100f;
public Transform player;
float xRotation = 0f;

    // Start is called before the first frame update
    void Start() {
        //makes it so you can't see the cursor only the crosshair image
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        //tracks the directionn of the cursor and has the crosshair follow it
        float MouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //moves the player
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * MouseX);
    }

    public void gameOver() {
        //makes the cursor visible
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}

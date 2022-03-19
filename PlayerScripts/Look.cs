using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code was made following a toutorial on the youtube channel Brackeys
//the url is: 

public class Look : MonoBehaviour {

public float mouseSens = 100f;
public Transform player;
float xRotation = 0f;

    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        float MouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * MouseX);
    }

    public void gameOver() {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}

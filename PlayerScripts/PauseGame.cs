using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this scripts is for checking the input of the player and pausing the game at the appropriate time

public class PauseGame : MonoBehaviour {

    private GameObject[] enemies;
    public GameObject pausePanel;
    public bool isPaused;


    void Start() {
        isPaused = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("v")) {
            Pause();
            isPaused = true;
        }
    }

    void Pause() {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
            AudioManager audioManager = enemy.GetComponent<AudioManager>();
            audioManager.stopSound("Walk");
        }
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
}

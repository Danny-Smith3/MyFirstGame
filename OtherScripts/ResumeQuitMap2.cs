using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeQuitMap2 : MonoBehaviour {

    private GameObject[] enemies;
    public PauseGameMap2 pauseScript;

    public void Resume() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        pauseScript.isPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
            AudioManager audioManager = enemy.GetComponent<AudioManager>();
            audioManager.playSound("Walk");
        }
    }

    public void Quit() {
        Debug.Log("Quitting");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        Application.Quit();
    }
}

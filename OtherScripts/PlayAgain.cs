using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script reloads the current map over again after the game is over from the game over panel

public class PlayAgain : MonoBehaviour {
    public void playAgain() {
        Debug.Log("play again");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

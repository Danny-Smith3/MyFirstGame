using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour {
    public void playAgain() {
        Debug.Log("play again");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

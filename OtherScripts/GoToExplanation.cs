using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script goes to the how to play PvE screen

public class GoToExplanation : MonoBehaviour {
    public void goToHowToScene() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("HowToPlayPvEScreen");
    }
}

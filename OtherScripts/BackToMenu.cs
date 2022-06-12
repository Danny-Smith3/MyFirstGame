using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script loads the PvEMenuScreen and plays a sound when the button is clicked
//the fromPause method was implemented after I added the pause feature because there was a bug where the game would be frozen after I paused went to menu and reloaded the map (basically the timescale was still frozen)

public class BackToMenu : MonoBehaviour {
    public void backToMenu() {
        Debug.Log("back to pve menu");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("PvEMenuScreen");
    }

    public void backToMenuFromPause() {
        Time.timeScale = 1f;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("PvEMenuScreen");
    }
}

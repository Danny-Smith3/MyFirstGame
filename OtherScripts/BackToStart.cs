using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStart : MonoBehaviour {
    public void backToStart() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("StartingScreen");
    }
}

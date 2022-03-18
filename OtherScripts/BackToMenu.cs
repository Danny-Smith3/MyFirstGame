using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
    public void backToMenu() {
        Debug.Log("back to pve menu");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("PvEMenuScreen");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BRMenu : MonoBehaviour {
    public void toBRMenu() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("BRMenuScreen");
    }
}

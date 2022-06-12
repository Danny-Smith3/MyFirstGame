using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script loads the BRMEnuScreen. The BRMenuScreen/BR Mode is not something I have worked on as part of this project I just added this incase I wanted to do it later

public class BRMenu : MonoBehaviour {
    public void toBRMenu() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("BRMenuScreen");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PvPMenu : MonoBehaviour {
    public void toPvPMenu() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("PvPMenuScreen");
    }
}

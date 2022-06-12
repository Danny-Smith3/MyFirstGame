using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this script loads the PvP menu. The PvPMenu/ PvP mode is not something I worked on for this project. This would be the next thing I worked on after finishing PvE mode

public class PvPMenu : MonoBehaviour {
    public void toPvPMenu() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        SceneManager.LoadScene("PvPMenuScreen");
    }
}

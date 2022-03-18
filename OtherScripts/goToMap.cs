using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToMap : MonoBehaviour {

    private int mapIndex = 0;
    private bool isEasy = true;

    public void toMap() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        if (mapIndex == 0) {
            SceneManager.LoadScene("Map1");
        } else if (mapIndex == 1) {
            SceneManager.LoadScene("Map2");
        } else if (mapIndex == 2) {
            SceneManager.LoadScene("Map3");
        } else {
            float rand = Random.Range(-.5f, 2.5f);
            mapIndex = Mathf.RoundToInt(rand);
            if (mapIndex == 0) {
                SceneManager.LoadScene("Map1");
            } else if (mapIndex == 1) {
                SceneManager.LoadScene("Map2");
            } else {
                SceneManager.LoadScene("Map3");
            }
        }
    }

    public void changeMap1() {
        mapIndex = 0;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    public void changeMap2() {
        mapIndex = 1;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    public void changeMap3() {
        mapIndex = 2;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    public void changeMap4() {
        mapIndex = 3;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    public void makeEasy() {
        isEasy = true;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    public void makeHard() {
        isEasy = false;
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }
}

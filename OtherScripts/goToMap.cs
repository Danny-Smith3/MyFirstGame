using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//this script is where going to different maps is handled

public class goToMap : MonoBehaviour {

    private int mapIndex = 0;
    private bool isEasy = true;
    public TMP_Text mapText;
    public TMP_Text difficultyText;

    public void toMap() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        if (mapIndex == 0) {
            SpawnEnemy.difficultyMap1 = isEasy;
            SceneManager.LoadScene("Map1");
        } else if (mapIndex == 1) {
            SpawnEnemyMap2.difficultyMap2 = isEasy;
            SceneManager.LoadScene("Map2");
        } else if (mapIndex == 2) {
            SpawnEnemyMap3.difficultyMap3 = isEasy;
            SceneManager.LoadScene("Map3");
        } else {
            //this is the random map feature
            float rand = Random.Range(-.5f, 2.5f);
            mapIndex = Mathf.RoundToInt(rand);
            if (mapIndex == 0) {
                SpawnEnemy.difficultyMap1 = isEasy;
                SceneManager.LoadScene("Map1");
            } else if (mapIndex == 1) {
                SpawnEnemyMap2.difficultyMap2 = isEasy;
                SceneManager.LoadScene("Map2");
            } else {
                SpawnEnemyMap3.difficultyMap3 = isEasy;
                SceneManager.LoadScene("Map3");
            }
        }
    }

    void Update() {
        //sets current selection map text
        if (mapIndex == 0) {
            mapText.text = "Map 1";
        } else if (mapIndex == 1) {
            mapText.text = "Map 2";
        } else if (mapIndex == 2) {
            mapText.text = "Map 3";
        } else {
            mapText.text = "Random";
        }

        //sets current selection difficulty text
        if (isEasy) {
            difficultyText.text = "Easy Mode";
        } else {
            difficultyText.text = "Hard Mode";
        }
    }

    //everything below this just updates the variables and plays sounds for button presses

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

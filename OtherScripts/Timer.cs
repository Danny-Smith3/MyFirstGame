using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//this script keeps track of the timer seen at the top of the UI, disables the bomb once interacted with, and if the time ever reaches 0 the game ends
//this is specific to map1 because of the different starting times due to the different sizes of maps

public class Timer : MonoBehaviour {

    public TMP_Text timerText;
    private float timeBeforeDetonate;
    private float secondsPastMinute;
    private bool bombEnabled = true;
    public GameObject explode;
    private bool won = true;

    // Start is called before the first frame update
    void Start() {
        timeBeforeDetonate = 120f;
    }

    // Update is called once per frame
    void Update() {
        if (bombEnabled) {
            //if time reaches 0
            if (timeBeforeDetonate < 0f) {
                won = false;
                ParticleSystem[] particles = explode.GetComponentsInChildren<ParticleSystem>();
                GameObject bomb = GameObject.Find("Bomb");
                AudioSource bombSound = bomb.GetComponent<AudioSource>();
                bombSound.Play();
                foreach (ParticleSystem particle in particles) {
                    Debug.Log("explode");
                    particle.Play();
                }
                bombDisable();
            }
            //updates time
            timeBeforeDetonate -= Time.deltaTime;
            if (timeBeforeDetonate < 60f) {
                timerText.text = "Bomb Timer: 0:" + Mathf.Round(timeBeforeDetonate).ToString();
            } else if (timeBeforeDetonate < 120f) {
                secondsPastMinute = timeBeforeDetonate - 60f;
                timerText.text = "Bomb Timer: 1:" + Mathf.Round(secondsPastMinute).ToString();
            } else {
                secondsPastMinute = timeBeforeDetonate - 120f;
                timerText.text = "Bomb Timer: 2:" + Mathf.Round(secondsPastMinute).ToString();
            }
        }
    }

    //disables bomb and ends game
    public void bombDisable() {
        bombEnabled = false;
        GameObject player = GameObject.Find("Player");
        PlayerHealth health = player.GetComponent<PlayerHealth>();
        health.didWin = won;
        health.startEndGame();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script spawns in the keycards for map2. There are 11 different possible spawn locations
//multiple keycards can be at the same location

public class SpawnKeycardsMap2 : MonoBehaviour {

    public GameObject keycard1;
    public GameObject keycard2;
    public GameObject keycard3;
    public GameObject keycard4;
    // Start is called before the first frame update
    void Start() {
        float randomNum = Mathf.Round(Random.value * 11);
        Vector3 spawnPoint;
        if (randomNum <= 1) {
            spawnPoint = new Vector3(91.5f, 1.05f, 43.5f);
        } else if (randomNum <= 2) {
            spawnPoint = new Vector3(33f, 1.05f, 27f);
        } else if (randomNum <= 3) {
            spawnPoint = new Vector3(30f, 1.05f, 32.5f);
        } else if (randomNum <= 4) {
            spawnPoint = new Vector3(-37f, 1.05f, -33f);
        } else if (randomNum <= 5) {
            spawnPoint = new Vector3(-91.5f, 1.05f, -43.5f);
        } else if (randomNum <= 6) {
            spawnPoint = new Vector3(-41f, 1.05f, 0f);
        } else if (randomNum <= 7) {
            spawnPoint = new Vector3(-33f, 11.05f, 2f);
        } else if (randomNum <= 8) {
            spawnPoint = new Vector3(-33f, 11.05f, -18f);
        } else if (randomNum <= 9) {
            spawnPoint = new Vector3(51.5f, 11.05f, 3.5f);
        } else if (randomNum <= 10) {
            spawnPoint = new Vector3(51.5f, 11.05f, -26.5f);
        } else {
            spawnPoint = new Vector3(46.5f, 11.05f, -21.5f);
        }
        keycard1.transform.position = spawnPoint;

        randomNum = Mathf.Round(Random.value * 11);
        if (randomNum <= 1) {
            spawnPoint = new Vector3(93.5f, 1.05f, 43.5f);
        } else if (randomNum <= 2) {
            spawnPoint = new Vector3(37f, 1.05f, 27f);
        } else if (randomNum <= 3) {
            spawnPoint = new Vector3(32f, 1.05f, 32.5f);
        } else if (randomNum <= 4) {
            spawnPoint = new Vector3(-33f, 1.05f, -33f);
        } else if (randomNum <= 5) {
            spawnPoint = new Vector3(-93.5f, 1.05f, -43.5f);
        } else if (randomNum <= 6) {
            spawnPoint = new Vector3(-41f, 1.05f, 2f);
        } else if (randomNum <= 7) {
            spawnPoint = new Vector3(-31f, 11.05f, 2f);
        } else if (randomNum <= 8) {
            spawnPoint = new Vector3(-33f, 11.05f, -20f);
        } else if (randomNum <= 9) {
            spawnPoint = new Vector3(53.5f, 11.05f, 3.5f);
        } else if (randomNum <= 10) {
            spawnPoint = new Vector3(53.5f, 11.05f, -26.5f);
        } else {
            spawnPoint = new Vector3(48.5f, 11.05f, -21.5f);
        }
        keycard2.transform.position = spawnPoint;

        randomNum = Mathf.Round(Random.value * 11);
        if (randomNum <= 1) {
            spawnPoint = new Vector3(93.5f, 1.05f, 41.5f);
        } else if (randomNum <= 2) {
            spawnPoint = new Vector3(37f, 1.05f, 23f);
        } else if (randomNum <= 3) {
            spawnPoint = new Vector3(34f, 1.05f, 32.5f);
        } else if (randomNum <= 4) {
            spawnPoint = new Vector3(-33f, 1.05f, -37f);
        } else if (randomNum <= 5) {
            spawnPoint = new Vector3(-93.5f, 1.05f, -41.5f);
        } else if (randomNum <= 6) {
            spawnPoint = new Vector3(-41f, 1.05f, 4f);
        } else if (randomNum <= 7) {
            spawnPoint = new Vector3(-29f, 11.05f, 2f);
        } else if (randomNum <= 8) {
            spawnPoint = new Vector3(-33f, 11.05f, -22f);
        } else if (randomNum <= 9) {
            spawnPoint = new Vector3(53.5f, 11.05f, 1.5f);
        } else if (randomNum <= 10) {
            spawnPoint = new Vector3(53.5f, 11.05f, -28.5f);
        } else {
            spawnPoint = new Vector3(48.5f, 11.05f, -23.5f);
        }
        keycard3.transform.position = spawnPoint;

        randomNum = Mathf.Round(Random.value * 11);
        if (randomNum <= 1) {
            spawnPoint = new Vector3(91.5f, 1.05f, 41.5f);
        } else if (randomNum <= 2) {
            spawnPoint = new Vector3(33f, 1.05f, 23f);
        } else if (randomNum <= 3) {
            spawnPoint = new Vector3(36f, 1.05f, 32.5f);
        } else if (randomNum <= 4) {
            spawnPoint = new Vector3(-37f, 1.05f, -37f);
        } else if (randomNum <= 5) {
            spawnPoint = new Vector3(-91.5f, 1.05f, -41.5f);
        } else if (randomNum <= 6) {
            spawnPoint = new Vector3(-41f, 1.05f, 6f);
        } else if (randomNum <= 7) {
            spawnPoint = new Vector3(-27f, 11.05f, 2f);
        } else if (randomNum <= 8) {
            spawnPoint = new Vector3(-33f, 11.05f, -24f);
        } else if (randomNum <= 9) {
            spawnPoint = new Vector3(51.5f, 11.05f, 1.5f);
        } else if (randomNum <= 10) {
            spawnPoint = new Vector3(51.5f, 11.05f, -28.5f);
        } else {
            spawnPoint = new Vector3(46.5f, 11.05f, -23.5f);
        }
        keycard4.transform.position = spawnPoint;
    }
}

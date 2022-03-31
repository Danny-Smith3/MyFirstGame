using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyMap2 : MonoBehaviour {

public GameObject prefab;
public bool difficulty = true;

    // Start is called before the first frame update
    void Start() {
        if (difficulty == true) {
            //spawn in 5 enemies
            //this version spawns them in at random positions
            float randomNum = Mathf.Round(Random.value * 4);
            Vector3 spawnPoint;
            if (randomNum <= 1) {
                spawnPoint = new Vector3(37.5f, 13f, 32.5f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-90f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(62.5f, 3f, -37.5f);
            } else {
                spawnPoint = new Vector3(-42.5f, 3f, 42.5f);
            }
            GameObject enemy1 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
            randomNum = Mathf.Round(Random.value * 4);
            if (randomNum <= 1) {
                spawnPoint = new Vector3(42.5f, 13f, 32.5f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-87.5f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(67.5f, 3f, -37.5f);
            } else {
                spawnPoint = new Vector3(-37.5f, 3f, 42.5f);
            }
            GameObject enemy2 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
            randomNum = Mathf.Round(Random.value * 4);
            if (randomNum <= 1) {
                spawnPoint = new Vector3(42.5f, 13f, 27.5f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-85f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(67.5f, 3f, -42.5f);
            } else {
                spawnPoint = new Vector3(-37.5f, 3f, 37.5f);
            }
            GameObject enemy3 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
            randomNum = Mathf.Round(Random.value * 4);
            if (randomNum <= 1) {
                spawnPoint = new Vector3(37.5f, 13f, 27.5f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-82.5f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(62.5f, 3f, -42.5f);
            } else {
                spawnPoint = new Vector3(-42.5f, 3f, 37.5f);
            }
            GameObject enemy4 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
            randomNum = Mathf.Round(Random.value * 4);
            if (randomNum <= 1) {
                spawnPoint = new Vector3(40f, 13f, 30f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-80f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(65f, 3f, -40f);
            } else {
                spawnPoint = new Vector3(-40f, 3f, 40f);
            }
            GameObject enemy5 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
        } else {
            //when difficulty is hard. spawn in 10 enemies
        }
    }
}

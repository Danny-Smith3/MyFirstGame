using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script spawns in the enemies for map2
//there are 4 general locations for enemies to spawn with offsets depending the enemy number
//each bock of code starting from picking a random number down to instantiating an enemy is for one enemy

public class SpawnEnemyMap2 : MonoBehaviour {

public GameObject prefab;
public static bool difficultyMap2;

    // Start is called before the first frame update
    void Start() {
        if (difficultyMap2) {
            //spawn in 4 enemies for easy mode
            //this version spawns them in at random positions
            Vector3 spawnPoint;

            float randomNum = Mathf.Round(Random.value * 4);
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
        } else {
            //when difficulty is hard. spawn in 6 enemies
            //this version spawns them in at random positions
            Vector3 spawnPoint;

            float randomNum = Mathf.Round(Random.value * 4);
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
                spawnPoint = new Vector3(37.5f, 13f, 30f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-80f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(62.5f, 3f, -40f);
            } else {
                spawnPoint = new Vector3(-37.5f, 3f, 40f);
            }
            GameObject enemy5 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);

            randomNum = Mathf.Round(Random.value * 4);
            if (randomNum <= 1) {
                spawnPoint = new Vector3(40f, 13f, 30f);
            } else if (randomNum <= 2) {
                spawnPoint = new Vector3(-77.5f, 13f, -45f);
            } else if (randomNum <= 3) {
                spawnPoint = new Vector3(67.5f, 3f, -40f);
            } else {
                spawnPoint = new Vector3(-42.5f, 3f, 40f);
            }
            GameObject enemy6 = Instantiate(prefab, spawnPoint, prefab.transform.localRotation);
        }
    }
}

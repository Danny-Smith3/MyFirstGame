using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

public GameObject prefab;
public bool difficulty = true;

    // Start is called before the first frame update
    void Start() {
        if (difficulty == true) {
            //spawn in 5 enemies
            GameObject enemy1 = Instantiate(prefab, new Vector3(62.5f, 2f, 62.5f), prefab.transform.localRotation);
            GameObject enemy2 = Instantiate(prefab, new Vector3(60f, 2f, 60f), prefab.transform.localRotation);
            GameObject enemy3 = Instantiate(prefab, new Vector3(65f, 2f, 65f), prefab.transform.localRotation);
            GameObject enemy4 = Instantiate(prefab, new Vector3(60f, 2f, 65f), prefab.transform.localRotation);
            GameObject enemy5 = Instantiate(prefab, new Vector3(65f, 2f, 60f), prefab.transform.localRotation);
            float randomNum = Mathf.Round(Random.value * 5);
            GameObject key = GameObject.Find("Keycard");
            Show showKey = key.GetComponent<Show>();
            if (randomNum <= 1) {
                showKey.enemy = enemy1.transform;
                Health healthScript1 = enemy1.GetComponent<Health>();
                healthScript1.hasKey = true;
            } else if (randomNum <= 2) {
                showKey.enemy = enemy2.transform;
                Health healthScript2 = enemy2.GetComponent<Health>();
                healthScript2.hasKey = true;
            } else if (randomNum <= 3) {
                showKey.enemy = enemy3.transform;
                Health healthScript3 = enemy3.GetComponent<Health>();
                healthScript3.hasKey = true;
            } else if (randomNum <= 4) {
                showKey.enemy = enemy4.transform;
                Health healthScript4 = enemy4.GetComponent<Health>();
                healthScript4.hasKey = true;
            } else {
                showKey.enemy = enemy5.transform;
                Health healthScript5 = enemy5.GetComponent<Health>();
                healthScript5.hasKey = true;
            }
        } else {
            //when difficulty is hard. spawn in 10 enemies
        }
    }
}

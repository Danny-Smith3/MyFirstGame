using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyMap3 : MonoBehaviour {

public GameObject prefab;
public bool difficulty = true;

    // Start is called before the first frame update
    void Start() {
        if (difficulty == true) {
            //enemies in north west village
            GameObject enemy1 = Instantiate(prefab, new Vector3(42.5f, 24.85f, 217.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior1 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior1.locationID = 1;
            behavior1.setInitialDestination();
            GameObject enemy2 = Instantiate(prefab, new Vector3(42.5f, 24.85f, 212.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior2 = enemy2.GetComponent<EnemyBehaviorMap3>();
            behavior2.locationID = 1;
            behavior2.setInitialDestination();
            GameObject enemy3 = Instantiate(prefab, new Vector3(47.5f, 24.85f, 217.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior3 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior3.locationID = 1;
            behavior3.setInitialDestination();
            GameObject enemy4 = Instantiate(prefab, new Vector3(47.5f, 24.85f, 212.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior4 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior4.locationID = 1;
            behavior4.setInitialDestination();

            //enemies in west village
            GameObject enemy5 = Instantiate(prefab, new Vector3(182.5f, 14.5f, 152.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior5 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior5.locationID = 2;
            behavior5.setInitialDestination();
            GameObject enemy6 = Instantiate(prefab, new Vector3(182.5f, 14.5f, 147.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior6 = enemy2.GetComponent<EnemyBehaviorMap3>();
            behavior6.locationID = 2;
            behavior6.setInitialDestination();
            GameObject enemy7 = Instantiate(prefab, new Vector3(177.5f, 14.5f, 152.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior7 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior7.locationID = 2;
            behavior7.setInitialDestination();
            GameObject enemy8 = Instantiate(prefab, new Vector3(177.5f, 14.5f, 147.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior8 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior8.locationID = 2;
            behavior8.setInitialDestination();

            //enemies in south village
            GameObject enemy9 = Instantiate(prefab, new Vector3(167.5f, 19.65f, 12.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior9 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior9.locationID = 3;
            behavior9.setInitialDestination();
            GameObject enemy10 = Instantiate(prefab, new Vector3(167.5f, 19.65f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior10 = enemy2.GetComponent<EnemyBehaviorMap3>();
            behavior10.locationID = 3;
            behavior10.setInitialDestination();
            GameObject enemy11 = Instantiate(prefab, new Vector3(162.5f, 19.65f, 12.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior11 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior11.locationID = 3;
            behavior11.setInitialDestination();
            GameObject enemy12 = Instantiate(prefab, new Vector3(162.5f, 19.65f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior12 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior12.locationID = 3;
            behavior12.setInitialDestination();
        } else {
            //when difficulty is hard. spawn in 10 enemies
        }
    }
}

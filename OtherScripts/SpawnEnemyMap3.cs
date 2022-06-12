using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyMap3 : MonoBehaviour {

public GameObject prefab;
public static bool difficultyMap3;

    // Start is called before the first frame update
    //Every 3 lines is for one enemy. Villages are seperated by space. If Else seperates difficulty
    //Line 1 in group of 3 lines instantiates an enemy. Line 2 gets behavior script for that enemy. Line 3 sets locationID in behavior script for that enemy

    void Start() {
        //when difficulty is easy spawn in 4 enemies per village
        if (difficultyMap3) {
            //enemies in north west village
            GameObject enemy1 = Instantiate(prefab, new Vector3(72.5f, 34.25f, 322.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior1 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior1.locationID = 1;
            GameObject enemy2 = Instantiate(prefab, new Vector3(72.5f, 34.25f, 317.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior2 = enemy2.GetComponent<EnemyBehaviorMap3>();
            behavior2.locationID = 1;
            GameObject enemy3 = Instantiate(prefab, new Vector3(67.5f, 34.25f, 317.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior3 = enemy3.GetComponent<EnemyBehaviorMap3>();
            behavior3.locationID = 1;
            GameObject enemy4 = Instantiate(prefab, new Vector3(67.5f, 34.25f, 322.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior4 = enemy4.GetComponent<EnemyBehaviorMap3>();
            behavior4.locationID = 1;

            //enemies in west village
            GameObject enemy5 = Instantiate(prefab, new Vector3(252.5f, 18.65f, 162.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior5 = enemy5.GetComponent<EnemyBehaviorMap3>();
            behavior5.locationID = 2;
            GameObject enemy6 = Instantiate(prefab, new Vector3(252.5f, 18.65f, 167.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior6 = enemy6.GetComponent<EnemyBehaviorMap3>();
            behavior6.locationID = 2;
            GameObject enemy7 = Instantiate(prefab, new Vector3(247.5f, 18.65f, 162.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior7 = enemy7.GetComponent<EnemyBehaviorMap3>();
            behavior7.locationID = 2;
            GameObject enemy8 = Instantiate(prefab, new Vector3(247.5f, 18.65f, 167.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior8 = enemy8.GetComponent<EnemyBehaviorMap3>();
            behavior8.locationID = 2;

            //enemies in south village
            GameObject enemy9 = Instantiate(prefab, new Vector3(247.5f, 26.45f, 22.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior9 = enemy9.GetComponent<EnemyBehaviorMap3>();
            behavior9.locationID = 3;
            GameObject enemy10 = Instantiate(prefab, new Vector3(247.5f, 26.45f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior10 = enemy10.GetComponent<EnemyBehaviorMap3>();
            behavior10.locationID = 3;
            GameObject enemy11 = Instantiate(prefab, new Vector3(252.5f, 26.45f, 22.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior11 = enemy11.GetComponent<EnemyBehaviorMap3>();
            behavior11.locationID = 3;
            GameObject enemy12 = Instantiate(prefab, new Vector3(252.5f, 26.45f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior12 = enemy12.GetComponent<EnemyBehaviorMap3>();
            behavior12.locationID = 3;
        } else {
            //when difficulty is hard. spawn in 6 enemies per village
            //enemies in north west village
            GameObject enemy1 = Instantiate(prefab, new Vector3(72.5f, 34.25f, 322.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior1 = enemy1.GetComponent<EnemyBehaviorMap3>();
            behavior1.locationID = 1;
            GameObject enemy2 = Instantiate(prefab, new Vector3(72.5f, 34.25f, 317.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior2 = enemy2.GetComponent<EnemyBehaviorMap3>();
            behavior2.locationID = 1;
            GameObject enemy3 = Instantiate(prefab, new Vector3(67.5f, 34.25f, 317.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior3 = enemy3.GetComponent<EnemyBehaviorMap3>();
            behavior3.locationID = 1;
            GameObject enemy4 = Instantiate(prefab, new Vector3(67.5f, 34.25f, 322.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior4 = enemy4.GetComponent<EnemyBehaviorMap3>();
            behavior4.locationID = 1;
            GameObject enemy5 = Instantiate(prefab, new Vector3(67.5f, 34.25f, 320f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior5 = enemy5.GetComponent<EnemyBehaviorMap3>();
            behavior5.locationID = 1;
            GameObject enemy6 = Instantiate(prefab, new Vector3(72.5f, 34.25f, 320f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior6 = enemy6.GetComponent<EnemyBehaviorMap3>();
            behavior6.locationID = 1;

            //enemies in west village
            GameObject enemy7 = Instantiate(prefab, new Vector3(252.5f, 18.65f, 162.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior7 = enemy7.GetComponent<EnemyBehaviorMap3>();
            behavior7.locationID = 2;
            GameObject enemy8 = Instantiate(prefab, new Vector3(252.5f, 18.65f, 167.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior8 = enemy8.GetComponent<EnemyBehaviorMap3>();
            behavior8.locationID = 2;
            GameObject enemy9 = Instantiate(prefab, new Vector3(247.5f, 18.65f, 162.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior9 = enemy9.GetComponent<EnemyBehaviorMap3>();
            behavior9.locationID = 2;
            GameObject enemy10 = Instantiate(prefab, new Vector3(247.5f, 18.65f, 167.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior10 = enemy10.GetComponent<EnemyBehaviorMap3>();
            behavior10.locationID = 2;
            GameObject enemy11 = Instantiate(prefab, new Vector3(247.5f, 18.65f, 165f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior11 = enemy11.GetComponent<EnemyBehaviorMap3>();
            behavior11.locationID = 2;
            GameObject enemy12 = Instantiate(prefab, new Vector3(252.5f, 18.65f, 165f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior12 = enemy12.GetComponent<EnemyBehaviorMap3>();
            behavior12.locationID = 2;

            //enemies in south village
            GameObject enemy13 = Instantiate(prefab, new Vector3(247.5f, 26.45f, 22.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior13 = enemy13.GetComponent<EnemyBehaviorMap3>();
            behavior13.locationID = 3;
            GameObject enemy14 = Instantiate(prefab, new Vector3(247.5f, 26.45f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior14 = enemy14.GetComponent<EnemyBehaviorMap3>();
            behavior14.locationID = 3;
            GameObject enemy15 = Instantiate(prefab, new Vector3(252.5f, 26.45f, 22.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior15 = enemy15.GetComponent<EnemyBehaviorMap3>();
            behavior15.locationID = 3;
            GameObject enemy16 = Instantiate(prefab, new Vector3(252.5f, 26.45f, 17.5f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior16 = enemy16.GetComponent<EnemyBehaviorMap3>();
            behavior16.locationID = 3;
            GameObject enemy17 = Instantiate(prefab, new Vector3(252.5f, 26.45f, 20f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior17 = enemy17.GetComponent<EnemyBehaviorMap3>();
            behavior17.locationID = 3;
            GameObject enemy18 = Instantiate(prefab, new Vector3(247.5f, 26.45f, 20f), prefab.transform.localRotation);
            EnemyBehaviorMap3 behavior18 = enemy18.GetComponent<EnemyBehaviorMap3>();
            behavior18.locationID = 3;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script spawns in the bomb into one of the 3 villages in map3

public class SpawnBombMap3 : MonoBehaviour {

    Quaternion tempQuaternion;

    void Start() {
        float spawnNumber = Mathf.Round(Random.value * 3);
        Vector3 position1 = new Vector3(62.5f, 32f, 362.5f);
        Vector3 position2 = new Vector3(272.5f, 17.5f, 235f);
        Vector3 position3 = new Vector3(315f, 25f, 95f);
        if (spawnNumber <= 1f) {
            transform.position = position1;
            tempQuaternion.eulerAngles = new Vector3(0f, -45f, 90f);
            transform.rotation = tempQuaternion;
        } else if (spawnNumber <= 2f) {
            transform.position = position2;
            tempQuaternion.eulerAngles = new Vector3(0f, 0f, 90f);
            transform.rotation = tempQuaternion;
        } else {
            transform.position = position3;
            tempQuaternion.eulerAngles = new Vector3(0f, 45f, 90f);
            transform.rotation = tempQuaternion;
        }
    }
}

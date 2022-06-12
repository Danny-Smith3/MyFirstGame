using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script moves the forcefield to the correct position on map 1 out of 3 possible positions
//the spawn bomb script is related to this one
//the spawn keycard reader is related to this one
//after the spawn point is chosen in this script it is sent out to those other two scripts

public class Spawn : MonoBehaviour {
    private float spawnNumber;
    public SpawnKeycardReader reader;
    public SpawnBomb bomb;

    // Start is called before the first frame update
    void Start() {
        spawnNumber = Random.Range(0f, 3f);
        reader.spawnNumber = spawnNumber;
        reader.spawn();
        bomb.spawnNumber = spawnNumber;
        bomb.spawn();
        Vector3 position1 = new Vector3(0f, -2.5f, 0f);
        Vector3 position2 = new Vector3(30f, -2.5f, -30f);
        Vector3 position3 = new Vector3(-30f, -2.5f, 30f);
        if (spawnNumber <= 1f) {
            gameObject.transform.position = position1;
        } else if (spawnNumber <= 2f) {
            gameObject.transform.position = position2;
        } else {
            gameObject.transform.position = position3;
        }
    }
}

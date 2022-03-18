using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour {
    public float spawnNumber = -1f;

    // Start is called before the first frame update
    public void spawn() {
        Vector3 position1 = new Vector3(0f, 1f, 0f);
        Vector3 position2 = new Vector3(30f, 1f, -30f);
        Vector3 position3 = new Vector3(-30f, 1f, 30f);
        if (spawnNumber <= 1f) {
            gameObject.transform.position = position1;
        } else if (spawnNumber <= 2f) {
            gameObject.transform.position = position2;
        } else {
            gameObject.transform.position = position3;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKeycardReader : MonoBehaviour {
    public float spawnNumber = -1f;

    // Start is called before the first frame update
    public void spawn() {
        Vector3 position1 = new Vector3(1.5f, 0f, -2.75f);
        Vector3 position2 = new Vector3(31.5f, 0f, -32.75f);
        Vector3 position3 = new Vector3(-28.5f, 0f, 27.25f);
        if (spawnNumber <= 1f) {
            gameObject.transform.position = position1;
        } else if (spawnNumber <= 2f) {
            gameObject.transform.position = position2;
        } else {
            gameObject.transform.position = position3;
        }
    }
}

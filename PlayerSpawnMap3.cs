using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnMap3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        float randomNum = Mathf.Round(Random.value * 3);
        if (randomNum <= 1) {
            transform.position = new Vector3(285f, 17f, 150f);
        } else if (randomNum <= 2) {
            transform.position = new Vector3(25f, 7.5f, 65f);
        } else {
            transform.position = new Vector3(150f, 14.5f, 260f);
        }
    }
}

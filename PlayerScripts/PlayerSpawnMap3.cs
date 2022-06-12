using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles player spawning for map3

public class PlayerSpawnMap3 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        float randomNum = Mathf.Round(Random.value * 3);
        if (randomNum <= 1) {
            transform.position = new Vector3(420f, 25.5f, 225f);
        } else if (randomNum <= 2) {
            transform.position = new Vector3(70f, 10.5f, 110f);
        } else {
            transform.position = new Vector3(220f, 21.8f, 400f);
        }
    }
}

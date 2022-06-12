using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//handles player spawning for map2
//picks a position out of 3 options
//there is no player spawn script for map1 since the player only ever spawns in one place

public class PlayerSpawnMap2 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        float randomNum = Mathf.Round(Random.value * 3);
        if (randomNum <= 1) {
            transform.position = new Vector3(-90f, 3f, -40f);
        } else if (randomNum <= 2) {
            transform.position = new Vector3(-90f, 13f, 0f);
        } else {
            transform.position = new Vector3(90f, 13f, -15f);
        }
    }
}

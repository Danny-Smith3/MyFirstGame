using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour {
    private bool ammoBoxUsed = false;

    // Start is called before the first frame update
    void Start() {
        Vector3 position1 = new Vector3(27.5f, 14.375f, 27.5f);
        Vector3 position2 = new Vector3(-27.5f, 14.375f, -27.5f);
        Vector3 position3 = new Vector3(60f, 14.375f, -60f);
        Vector3 position4 = new Vector3(-60f, 14.375f, 60f);
        float spawnNumber = Random.Range(0f, 4f);
        if (spawnNumber <= 1f) {
            transform.position = position1;
        } else if (spawnNumber <= 2f) {
            transform.position = position2;
        } else if (spawnNumber <= 3f) {
            transform.position = position3;
        } else {
            transform.position = position4;
        }
    }

    public void useAmmoBox() {
        ammoBoxUsed = true;
    }

    public bool getAmmo() {
        return ammoBoxUsed;
    }
}

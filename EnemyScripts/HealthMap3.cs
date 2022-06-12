using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for enemy health on map3
//is simpler than the enemy health for map1 because there is no keycards

public class HealthMap3 : MonoBehaviour {

    private int health;

    void Start() {
        health = 100;
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            //death animation might be implemented later
            GameObject player = GameObject.Find("Player");
            GunScriptMap3 playerGun = player.GetComponent<GunScriptMap3>();
            playerGun.killConfirmed();
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage) {
        health -= damage;
    }
}

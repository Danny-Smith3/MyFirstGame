using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is responsible for the enemy health system on map 2

public class HealthMap2 : MonoBehaviour {

    private int health;
    public GameObject keycard;
    public bool hasKey = false;

    void Start() {
        keycard = GameObject.Find("Keycard");
        health = 100;
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            //death animation might be implemented later
            if (hasKey) {
                dropKeyCard();
            }
            GameObject player = GameObject.Find("Player");
            GunScriptMap2 playerGun = player.GetComponent<GunScriptMap2>();
            playerGun.killConfirmed();
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage) {
        health -= damage;
    }

    private void dropKeyCard() {
        Show key = keycard.GetComponent<Show>();
        key.enemyAlive(false);
        key.showKey(true);
    }
}

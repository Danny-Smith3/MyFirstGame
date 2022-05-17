using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            GunScript playerGun = player.GetComponent<GunScript>();
            playerGun.killConfirmed();
            Destroy(gameObject);
        }
    }

    public void takeDamage(int damage) {
        health -= damage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script handles the UI pieces of the inventory
//the 3 use healables functions are for when the buttons are pressed in the inventory

public class InventoryButtonsMap2 : MonoBehaviour {

    public HealthBarImage healthBar;
    public Keycard inventoryTracker;
    public PlayerHealthMap2 playerHealth;
    public GameObject healable1Image;
    public GameObject healable2Image;
    public GameObject healable3Image;

    public void useHeal1() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        if (inventoryTracker.hasHealable1) {
            healable1Image.SetActive(false);
            inventoryTracker.hasHealable1 = false;
            if (playerHealth.health < 50) {
                playerHealth.health += 50;
                healthBar.gainHealth();
            } else {
                playerHealth.health = 100;
                healthBar.maxHealth();
            }
        }
    }

    public void useHeal2() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        if (inventoryTracker.hasHealable2) {
            healable2Image.SetActive(false);
            inventoryTracker.hasHealable2 = false;
            if (playerHealth.health < 50) {
                playerHealth.health += 50;
                healthBar.gainHealth();
            } else {
                playerHealth.health = 100;
                healthBar.maxHealth();
            }
        }
    }

    public void useHeal3() {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
        if (inventoryTracker.hasHealable3) {
            healable2Image.SetActive(false);
            inventoryTracker.hasHealable3 = false;
            if (playerHealth.health < 50) {
                playerHealth.health += 50;
                healthBar.gainHealth();
            } else {
                playerHealth.health = 100;
                healthBar.maxHealth();
            }
        }
    }
}

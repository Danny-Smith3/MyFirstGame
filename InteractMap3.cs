using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class InteractMap3 : MonoBehaviour {

    public Transform camera;
    private bool foundBomb = false;
    public bool isAlive = true;
    public GameObject Healable1;
    public GameObject Healable2;
    public GameObject Healable3;
    public GameObject Healable4;
    public GameObject Healable5;
    public GameObject Healable6;
    public HealthBarImage healthBar;
    private bool foundHeal1 = false;
    private bool foundHeal2 = false;
    private bool foundHeal3 = false;
    private bool foundHeal4 = false;
    private bool foundHeal5 = false;
    private bool foundHeal6 = false;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("e")) {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.TransformDirection(Vector3.forward), out hit, 5f)) {
                if (hit.transform.name == "Bomb" && isAlive) {
                    Debug.Log("Bomb found");
                    TimerMap3 bomb = hit.transform.GetComponent<TimerMap3>();
                    Debug.Log("Bomb Disarmed");
                    if (!foundBomb) {
                        bomb.bombDisable();
                        foundBomb = true;
                    }
                }
                if (hit.transform.tag == "AmmoBox" && isAlive) {
                    //refresh ammo and is unlimited unlike ammo box on map 1
                    Debug.Log("Ammo box found");
                    GunScript gun = gameObject.GetComponent<GunScript>();
                    gun.ammoTotal = 90;
                }
                if (hit.transform.tag == "Healable" && isAlive) {
                    //use healable
                    Debug.Log("Found healable");
                    PlayerHealth playerHealth = gameObject.GetComponent<PlayerHealth>();
                    if (hit.transform.name == "Healable1" && !foundHeal1) {
                        Debug.Log("Found healable1");
                        Healable1.SetActive(false);
                        foundHeal1 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        }
                    } else if (hit.transform.name == "Healable2" && !foundHeal2) {
                        Debug.Log("Found healable2");
                        Healable2.SetActive(false);
                        foundHeal2 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        }
                    } else if (!foundHeal3) {
                        Debug.Log("Found healable3");
                        Healable3.SetActive(false);
                        foundHeal3 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        }
                    } else if (hit.transform.name == "Healable4" && !foundHeal4) {
                        Debug.Log("Found healable4");
                        Healable4.SetActive(false);
                        foundHeal4 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        }
                    } else if (hit.transform.name == "Healable5" && !foundHeal5) {
                        Debug.Log("Found healable5");
                        Healable5.SetActive(false);
                        foundHeal5 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        }
                    } else if (!foundHeal6) {
                        Debug.Log("Found healable6");
                        Healable6.SetActive(false);
                        foundHeal6 = true;
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
        }
    }
}

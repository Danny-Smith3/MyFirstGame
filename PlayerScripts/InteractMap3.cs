using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//handles interactions with objects by using raycasts
//very similar to map1 and map2 just checks for some different things
//also checks input for the map feature which is specific to map3
//only for map3

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
    public GameObject fullMap;
    private bool isMapOpen = false;
    public PauseGame pauseScript;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("e") && !pauseScript.isPaused) {
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
                    GunScriptMap3 gun = gameObject.GetComponent<GunScriptMap3>();
                    gun.ammoTotal = 90;
                }
                if (hit.transform.tag == "Healable" && isAlive) {
                    //use healable
                    Debug.Log("Found healable");
                    PlayerHealthMap3 playerHealth = gameObject.GetComponent<PlayerHealthMap3>();
                    if (hit.transform.name == "Village1Healable1" && !foundHeal1) {
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
                    } else if (hit.transform.name == "Village1Healable2" && !foundHeal2) {
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
                    } else if (hit.transform.name == "Village2Healable1" && !foundHeal3) {
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
                    } else if (hit.transform.name == "Village2Healable2" && !foundHeal4) {
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
                    } else if (hit.transform.name == "Village3Healable1" && !foundHeal5) {
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
                    } else if (hit.transform.name == "Village3Healable2" && !foundHeal6) {
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
        //map
        } else if (Input.GetKeyDown("q") && !pauseScript.isPaused) {
            if (isMapOpen) {
                fullMap.SetActive(false);
                isMapOpen = false;
            } else {
                fullMap.SetActive(true);
                isMapOpen = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//handles interactions with objects by using raycasts
//very similar to map1 just checks for some different things
//only for map2

public class InteractMap2 : MonoBehaviour {

    public Transform camera;
    private bool foundBomb = false;
    public bool isAlive = true;
    public Keycard keycardScript;
    public GameObject backpack;
    public GameObject Healable1;
    public GameObject Healable2;
    public GameObject Healable3;
    public HealthBarImage healthBar;
    private bool foundHeal1 = false;
    private bool foundHeal2 = false;
    private bool foundHeal3 = false;
    public PauseGameMap2 pauseScript;
    public InventoryMap2 inventory;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("e") && !pauseScript.isPaused && !inventory.inventoryOpen) {
            RaycastHit hit;
            //this bit was explained on the interact map1 script
            if (Physics.Raycast(camera.position, camera.TransformDirection(Vector3.forward), out hit, 5f)) {
                if (hit.transform.tag == "Keycard" && isAlive) {
                    if (hit.transform.name == "Keycard1") {
                        Debug.Log("found keycard1");
                        keycardScript.hasKeyCard1 = true;
                        ShowMap2 showCard = hit.transform.GetComponent<ShowMap2>();
                        showCard.showKey(false);
                    } else if (hit.transform.name == "Keycard2") {
                        Debug.Log("found keycard2");
                        keycardScript.hasKeyCard2 = true;
                        ShowMap2 showCard = hit.transform.GetComponent<ShowMap2>();
                        showCard.showKey(false);
                    } else if (hit.transform.name == "Keycard3") {
                        Debug.Log("found keycard3");
                        keycardScript.hasKeyCard3 = true;
                        ShowMap2 showCard = hit.transform.GetComponent<ShowMap2>();
                        showCard.showKey(false);
                    } else {
                        Debug.Log("found keycard4");
                        keycardScript.hasKeyCard4 = true;
                        ShowMap2 showCard = hit.transform.GetComponent<ShowMap2>();
                        showCard.showKey(false);
                    }
                }
                if (hit.transform.tag == "KeycardReader" && isAlive) {
                     if (hit.transform.name == "KeycardReader1") {
                        Debug.Log("found keycardReader1");
                        HideVaultWall keycardReader1 = hit.transform.GetComponent<HideVaultWall>();
                        if (keycardScript.hasKeyCard1) {
                            keycardReader1.disableVaultWall();
                        }
                    } else if (hit.transform.name == "KeycardReader2") {
                        Debug.Log("found keycardReader2");
                        HideVaultWall keycardReader2 = hit.transform.GetComponent<HideVaultWall>();
                        if (keycardScript.hasKeyCard2) {
                            keycardReader2.disableVaultWall();
                        }
                    } else if (hit.transform.name == "KeycardReader3") {
                        Debug.Log("found keycardReader3");
                        HideVaultWall keycardReader3 = hit.transform.GetComponent<HideVaultWall>();
                        if (keycardScript.hasKeyCard3) {
                            keycardReader3.disableVaultWall();
                        }
                    } else {
                        Debug.Log("found keycardReader4");
                        HideVaultWall keycardReader4 = hit.transform.GetComponent<HideVaultWall>();
                        if (keycardScript.hasKeyCard4) {
                            keycardReader4.disableVaultWall();
                        }
                    }
                }
                if (hit.transform.name == "Bomb" && isAlive) {
                    Debug.Log("Bomb found");
                    TimerMap2 bomb = hit.transform.GetComponent<TimerMap2>();
                    Debug.Log("Bomb Disarmed");
                    if (!foundBomb) {
                        bomb.bombDisable();
                        foundBomb = true;
                    }
                }
                if (hit.transform.tag == "AmmoBox" && isAlive) {
                    //refresh ammo and is unlimited unlike ammo box on map 1
                    Debug.Log("Ammo box found");
                    GunScriptMap2 gun = gameObject.GetComponent<GunScriptMap2>();
                    if (keycardScript.hasBackpack) {
                        gun.ammoTotal = 150;
                    } else {
                        gun.ammoTotal = 90;
                    }
                }
                if (hit.transform.tag == "Healable" && isAlive) {
                    //use healable
                    Debug.Log("Found healable");
                    PlayerHealthMap2 playerHealth = gameObject.GetComponent<PlayerHealthMap2>();
                    if (hit.transform.name == "Healable1" && !foundHeal1) {
                        Debug.Log("Found healable1");
                        Healable1.SetActive(false);
                        foundHeal1 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else if (playerHealth.health < 100) {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        } else if (keycardScript.hasBackpack == true) {
                            keycardScript.hasHealable1 = true;
                        }
                    } else if (hit.transform.name == "Healable2" && !foundHeal2) {
                        Debug.Log("Found healable2");
                        Healable2.SetActive(false);
                        foundHeal2 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else if (playerHealth.health < 100) {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        } else if (keycardScript.hasBackpack == true) {
                            keycardScript.hasHealable2 = true;
                        }
                    } else if (!foundHeal3) {
                        Debug.Log("Found healable3");
                        Healable3.SetActive(false);
                        foundHeal3 = true;
                        if (playerHealth.health < 50) {
                            playerHealth.health += 50;
                            healthBar.gainHealth();
                        } else if (playerHealth.health < 100) {
                            playerHealth.health = 100;
                            healthBar.maxHealth();
                        } else if (keycardScript.hasBackpack == true) {
                            keycardScript.hasHealable3 = true;
                        }
                    }
                }
                if (hit.transform.name == "Backpack" && isAlive) {
                    //upgrade weapon damage
                    Debug.Log("Found backpack");
                    backpack.SetActive(false);
                    keycardScript.hasBackpack = true;
                }
            }
        }
    }
}

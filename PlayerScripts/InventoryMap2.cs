using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script tracks the user input so the game knows when to open and close the inventory

public class InventoryMap2 : MonoBehaviour {

    public Keycard inventoryTracker;
    public GameObject inventoryPanel;
    public PauseGameMap2 pauseScript;
    public bool inventoryOpen;
    public GameObject healable1Image;
    public GameObject healable2Image;
    public GameObject healable3Image;
    public GameObject keycard1Image;
    public GameObject keycard2Image;
    public GameObject keycard3Image;
    public GameObject keycard4Image;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("f") && !pauseScript.isPaused) {
            if (inventoryOpen) {
                inventoryPanel.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                inventoryOpen = false;
            } else {
                inventoryPanel.SetActive(true);
                if (inventoryTracker.hasHealable1) {
                    healable1Image.SetActive(true);
                }
                if (inventoryTracker.hasHealable2) {
                    healable2Image.SetActive(true);
                }
                if (inventoryTracker.hasHealable3) {
                    healable3Image.SetActive(true);
                }
                if (inventoryTracker.hasKeyCard1) {
                    keycard1Image.SetActive(true);
                }
                if (inventoryTracker.hasKeyCard2) {
                    keycard2Image.SetActive(true);
                }
                if (inventoryTracker.hasKeyCard3) {
                    keycard3Image.SetActive(true);
                }
                if (inventoryTracker.hasKeyCard4) {
                    keycard4Image.SetActive(true);
                }
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
                inventoryOpen = true;
            }
        }
    }
}

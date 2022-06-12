using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

//handles interactions with objects by using raycasts
//only for map1

public class Interact : MonoBehaviour {

    public Transform camera;
    private bool foundBomb = false;
    public bool isAlive = true;
    public PauseGame pauseScript;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("e") && !pauseScript.isPaused) {
            RaycastHit hit;
            //raycast from the position of the camera, in the direction of the camera, distance of 5units (not very far so you have to be close to interact), everything from object that was hit is assigned to hit variable
            if (Physics.Raycast(camera.position, camera.TransformDirection(Vector3.forward), out hit, 5f)) {
                //checks for keycard
                if (hit.transform.tag == "Keycard") {
                    Debug.Log("found keycard");
                    KeycardMap1 key = gameObject.GetComponent<KeycardMap1>();
                    key.setKeyCard();
                    Show showCard = hit.transform.GetComponent<Show>();
                    showCard.showKey(false);
                }
                //checks for keycard reader
                if (hit.transform.tag == "KeycardReader" && isAlive) {
                    Debug.Log("found keycard reader");
                    KeycardMap1 keycard = gameObject.GetComponent<KeycardMap1>();
                    if (keycard.getKeyCard()) {
                        Debug.Log("deactivating force field");
                        GameObject forceField = GameObject.Find("Forcefield");
                        MeshRenderer forceFieldRend = forceField.GetComponent<MeshRenderer>();
                        MeshCollider forceFieldCollider = forceField.GetComponent<MeshCollider>();
                        AudioSource forceFieldSound = forceField.GetComponent<AudioSource>();
                        forceFieldSound.Play();
                        //play disable forcefield animation
                        forceFieldRend.enabled = false;
                        forceFieldCollider.enabled= false;
                    }   
                }
                //checks for bomb
                if (hit.transform.name == "Bomb" && isAlive) {
                    Debug.Log("Bomb found");
                    Timer bomb = hit.transform.GetComponent<Timer>();
                    Debug.Log("Bomb Disarmed");
                    if (!foundBomb) {
                        bomb.bombDisable();
                        foundBomb = true;
                    }
                }
                //checks for ammo
                if (hit.transform.name == "AmmoBox" && isAlive) {
                    Debug.Log("Ammo box found");
                    AmmoBox ammo = hit.transform.GetComponent<AmmoBox>();
                    if (!ammo.getAmmo()) {
                        GunScript gun = gameObject.GetComponent<GunScript>();
                        gun.ammoTotal = 90;
                        ammo.useAmmoBox();
                    }
                }
            }
        }
    }
}

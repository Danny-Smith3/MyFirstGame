using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Interact : MonoBehaviour {

    public Transform camera;
    private bool foundBomb = false;
    public bool isAlive = true;

    // Update is called once per frame
    void Update() {
        if (Input.GetKey("e")) {
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.TransformDirection(Vector3.forward), out hit, 5f)) {
                if (hit.transform.tag == "Keycard") {
                    Debug.Log("found keycard");
                    Keycard key = gameObject.GetComponent<Keycard>();
                    key.setKeyCard();
                    Show showCard = hit.transform.GetComponent<Show>();
                    showCard.showKey(false);
                }
                if (hit.transform.tag == "KeycardReader" && isAlive) {
                    Debug.Log("found keycard reader");
                    Keycard keycard = gameObject.GetComponent<Keycard>();
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
                if (hit.transform.name == "Bomb" && isAlive) {
                    Debug.Log("Bomb found");
                    Timer bomb = hit.transform.GetComponent<Timer>();
                    Debug.Log("Bomb Disarmed");
                    if (!foundBomb) {
                        bomb.bombDisable();
                        foundBomb = true;
                    }
                }
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

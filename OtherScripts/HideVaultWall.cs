using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script handles the action of disabling a vault wall after a keycard has been used to open it

public class HideVaultWall : MonoBehaviour {

    public GameObject vaultWall;

    public void disableVaultWall() {
        MeshRenderer vaultWallRend = vaultWall.GetComponent<MeshRenderer>();
        BoxCollider vaultWallCollider = vaultWall.GetComponent<BoxCollider>();
        AudioSource vaultWallSound = vaultWall.GetComponent<AudioSource>();
        vaultWallSound.Play();
        //play disable vaultWall animation
        vaultWallRend.enabled = false;
        vaultWallCollider.enabled= false;
    }

}

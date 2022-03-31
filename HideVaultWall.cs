using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

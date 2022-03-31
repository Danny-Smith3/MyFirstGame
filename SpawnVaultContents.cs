using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVaultContents : MonoBehaviour {

    public GameObject ammo;
    public GameObject healables;
    public GameObject bomb;
    public GameObject weapon;

    private float vault1x = 90f;
    private float vault1z = -40f;
    private float vault2x = -20f;
    private float vault2z = 40f;
    private float vault3x = 40f;
    private float vault3z = 10f;
    private float vault4x = -90;
    private float vault4z = -30;

    // Start is called before the first frame update
    void Start() {
        float randomNum = Mathf.Round(Random.value * 24);
        if (randomNum <= 1) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 2) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 3) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 4) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 5) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 6) {
            //ammo spawns in vault 1
            ammo.transform.position = new Vector3(vault1x + 7f, 1.135f, vault1z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 7) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 8) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 9) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 10) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 11) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 12) {
            //ammo spawns in vault 2
            ammo.transform.position = new Vector3(vault2x + 7f, 1.135f, vault2z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 13) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 14) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 15) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 4
            weapon.transform.position = new Vector3(vault4x - 2f, 10.375f, vault4z);
            weapon.transform.localRotation = Quaternion.Euler(0f, 90f, 90f);
        } else if (randomNum <= 16) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 4
            bomb.transform.position = new Vector3(vault4x, 12f, vault4z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 17) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 18) {
            //ammo spawns in vault 3
            ammo.transform.position = new Vector3(vault3x + 7f, 11.135f, vault3z);
            ammo.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //healables spawns in vault 4
            healables.transform.position = new Vector3(vault4x, 12f, vault4z + 5f);
            healables.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 19) {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 20) {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 1
            healables.transform.position = new Vector3(vault1x + 5f, 2f, vault1z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 21) {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 3
            bomb.transform.position = new Vector3(vault3x, 12f, vault3z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 22) {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 2
            healables.transform.position = new Vector3(vault2x + 5f, 2f, vault2z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 3
            weapon.transform.position = new Vector3(vault3x, 10.375f, vault3z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else if (randomNum <= 23) {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 1
            bomb.transform.position = new Vector3(vault1x, 2f, vault1z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 2
            weapon.transform.position = new Vector3(vault2x, .375f, vault2z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        } else {
            //ammo spawns in vault 4
            ammo.transform.position = new Vector3(vault4x, 11.135f, vault4z + 7f);
            ammo.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //healables spawns in vault 3
            healables.transform.position = new Vector3(vault3x + 5f, 12f, vault3z);
            healables.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            //bomb spawns in vault 2
            bomb.transform.position = new Vector3(vault2x, 2f, vault2z);
            bomb.transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
            //weapon spawns in vault 1
            weapon.transform.position = new Vector3(vault1x, .375f, vault1z + 2f);
            weapon.transform.localRotation = Quaternion.Euler(0f, 180f, 90f);
        }
    }
}

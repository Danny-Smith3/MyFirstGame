using UnityEngine;
using System.Collections;
using TMPro;

public class GunScript : MonoBehaviour {
    
    public Transform playerCamera;
    public TMP_Text ammoInGun;
    private int ammoIn;
    public TMP_Text totalAmmo;
    public int ammoTotal;
    private int ammoNeeded;
    private float fireRate = 5f;
    private float timeToFire = 0f;
    //part of script where the reload takes in game time was done from a tutorial
    private bool isReloading = false;
    private Vector3 bloom = new Vector3(0.035f, 0.035f, 0.035f);
    private int numberOfKills = 0;
    public bool gameOver = false;
    private AudioManager audio;
    public bool isAlive = true;

    void Start() {
        ammoInGun.text = "30";
        ammoIn = 30;
        totalAmmo.text = "90";
        ammoTotal = 90;
        audio = gameObject.GetComponent<AudioManager>();
    }

    void OnEnable() {
        isReloading = false;
    }

    // Update is called once per frame
    void Update() {
        if (gameOver) {
            return;
        }
        if (isReloading) {
            return;
        }
        if (Input.GetKeyDown("r") && isAlive && ammoIn < 30) {
            StartCoroutine(Reload()); 
            return;
        }
        if (ammoIn == 0) {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButton("Fire1") && ammoIn > 0 && Time.time > timeToFire && isAlive) {
            //this way of calculating fire rate was from a tutorial. Originally wouldn't shoot unless timeToFire = 0 and wouldn't increment timeToFire by -1 every frame
            timeToFire = Time.time + 1/fireRate;
            Shoot();
            //I haven't done anything with recoil yet
            Recoil recoil = playerCamera.GetComponent<Recoil>();
            recoil.addRecoil();
            ammoIn--;
        }
        ammoInGun.text = ammoIn.ToString();
        totalAmmo.text = ammoTotal.ToString();
    }

    private void Shoot() {
        //play shot sound
        audio.playSound("Shoot");
        Vector3 direction = playerCamera.TransformDirection(Vector3.forward);
        //this adds a variance to the shots so they are not hit scan
        //this way of adding bloom to a shot was from a tutorial
        direction += new Vector3(Random.Range(-bloom.x, bloom.x), Random.Range(-bloom.y, bloom.y), Random.Range(-bloom.z, bloom.z));
        //not sure yet why normalizing a vector is neccessary after changing it
        direction.Normalize();
        Shooting shot = gameObject.GetComponent<Shooting>();
        shot.Shoot(direction, playerCamera.transform.position, "Player");
    }

    private IEnumerator Reload() {

        isReloading = true;
        //play reload sound
        if (ammoTotal != 0) {
            audio.playSound("Reload");
        }

        yield return new WaitForSeconds(1.95f);

        if (ammoTotal > 0) {
            ammoNeeded = 30 - ammoIn;
            if (ammoNeeded >= ammoTotal) {
                ammoIn += ammoTotal;
                ammoTotal = 0;
            } else {
                ammoIn += ammoNeeded;
                ammoTotal -= ammoNeeded;                
            }
        }

        isReloading = false;
    }

    public void killConfirmed() {
        numberOfKills++;
    }
}

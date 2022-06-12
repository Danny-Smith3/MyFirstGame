using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//this script handles the behavior of enemies on map3. Is similar to other enemy behabiors with the difference being it is a 2 floor map
//general idea is that a point on the map is selected to be a patrol destination for an enemy. Once that is reached they get a new one. If they encounter the player on the way then they attack the player

public class EnemyBehaviorMap3 : MonoBehaviour {

    public Transform playerTransform;
    public NavMeshAgent navAgent;
    private Vector3 bloom = new Vector3(0.0795f, 0.0795f, 0.0795f);
    private int ammo = 30;
    private float fireRate = 5f;
    private float timeToFire = 0f;
    private bool isReloading = false;
    private bool travelingToDestination = true;
    private Vector3 patrolDestination;
    private float distanceToPlayer;
    private float distanceToPatrolTarget;
    private float distanceToHomeVillage;
    private AudioManager audio;
    public int locationID = 0;
    private Vector3 centerOfHomeVillage;

    // Start is called before the first frame update
    void Start() {
        GameObject player = GameObject.Find("Player");
        playerTransform = player.GetComponent<Transform>();

        if (locationID == 0) {
            patrolDestination = transform.position;
        } else if (locationID == 1) {
            patrolDestination = new Vector3(Random.Range(40f, 120f), 32.45f, Random.Range(310f, 380f));
        } else if (locationID == 2) {
            patrolDestination = new Vector3(Random.Range(210f, 330f), 16.5f, Random.Range(170f, 230f));
        } else {
            patrolDestination = new Vector3(Random.Range(250f, 330f), 25.5f, Random.Range(10f, 90f));
        }
        navAgent.destination = patrolDestination;
        distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
        distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        audio = gameObject.GetComponent<AudioManager>();
        //start the walking sound it is looping
        audio.playSound("Walk");
    }

    // Update is called once per frame
    void Update() {
        if (locationID != 0) {
            if (locationID == 1) {
                centerOfHomeVillage = new Vector3(80f, 32.45f, 350f);
            } else if (locationID == 2) {
                centerOfHomeVillage = new Vector3(270f, 16.5f, 200f);
            } else {
                centerOfHomeVillage = new Vector3(290f, 25.5f, 50f);
            }
            if (isReloading) {
                return;
            }
            if (ammo == 0) {
                StartCoroutine(Reload());
                return;
            }
            distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
            distanceToHomeVillage = Vector3.Distance(transform.position, centerOfHomeVillage);
            if (distanceToPlayer < 65 && distanceToHomeVillage < 80) {
                if (distanceToPlayer < 60f) {
                    //attack
                    navAgent.destination = playerTransform.position;
                    travelingToDestination = false;
                    if (ammo > 0 && Time.time > timeToFire) {
                        timeToFire = Time.time + 1/fireRate;
                        ShootShot();
                        ammo--;
                    }
                } else {
                    //chase
                    navAgent.destination = playerTransform.position;
                    travelingToDestination = false;
                }
            } else {
                //roam
                distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
                if (distanceToPatrolTarget < 7.5f) {
                    travelingToDestination = false;
                }
                if (!travelingToDestination) {
                    float randomNum = Mathf.Round(Random.value * 2);
                    if (locationID == 1) {
                        patrolDestination = new Vector3(Random.Range(40f, 120f), 32.45f, Random.Range(310f, 380f));
                    } else if (locationID == 2) {
                        patrolDestination = new Vector3(Random.Range(210f, 330f), 16.5f, Random.Range(170f, 230f));
                    } else {
                        patrolDestination = new Vector3(Random.Range(250f, 330f), 25.5f, Random.Range(10f, 90f));
                    }
                    navAgent.destination = patrolDestination;
                    distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
                    travelingToDestination = true;
                }
            }
        }
    }

    private void ShootShot() {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        //this adds a variance to the shots so they are not hit scan
        //this way of adding bloom to a shot was from a tutorial; same tutorial as the one that added the trails
        direction += new Vector3(Random.Range(-bloom.x, bloom.x), Random.Range(-bloom.y, bloom.y), Random.Range(-bloom.z, bloom.z));
        //not sure yet why normalizing a vector is neccessary after adding bloom/variance
        direction.Normalize();
        ShootingMap3 shot = gameObject.GetComponent<ShootingMap3>();
        Vector3 position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
        //play shot sound
        audio.playSound("Shoot");
        shot.Shoot(direction, position, "Enemy");
    }

    private IEnumerator Reload() {

        isReloading = true;
        //play reload sound
        audio.playSound("Reload");

        yield return new WaitForSeconds(1.95f);

        ammo = 30;

        isReloading = false;
    }
}

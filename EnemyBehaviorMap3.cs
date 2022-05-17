using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

        audio = gameObject.GetComponent<AudioManager>();
        //start the walking sound it is looping
        audio.playSound("Walk");
    }

    // Update is called once per frame
    void Update() {
        if (locationID != 0) {
            if (locationID == 1) {
                centerOfHomeVillage = new Vector3(60f, 22.85f, 235f);
            } else if (locationID == 2) {
                centerOfHomeVillage = new Vector3(180f, 12.5f, 130f);
            } else {
                centerOfHomeVillage = new Vector3(190f, 17.65f, 45f);
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
                if (distanceToPlayer < 50f) {
                    //attack
                    navAgent.destination = playerTransform.position;
                    if (ammo > 0 && Time.time > timeToFire) {
                        timeToFire = Time.time + 1/fireRate;
                        Shoot();
                        ammo--;
                    }
                } else {
                    //chase
                    navAgent.destination = playerTransform.position;
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
                        patrolDestination = new Vector3(Random.Range(20f, 100f), 22.85f, Random.Range(200f, 270f));
                    } else if (locationID == 2) {
                        patrolDestination = new Vector3(Random.Range(130f, 230f), 12.5f, Random.Range(160f, 100f));
                    } else if (locationID == 3) {
                        patrolDestination = new Vector3(Random.Range(150f, 230f), 17.65f, Random.Range(5f, 95f));
                    }
                    navAgent.destination = patrolDestination;
                    distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
                    travelingToDestination = true;
                }
            }
        }
    }

    private void Shoot() {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        //this adds a variance to the shots so they are not hit scan
        //this way of adding bloom to a shot was from a tutorial
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

    public void setInitialDestination() {
        if (locationID == 1) {
            patrolDestination = new Vector3(Random.Range(20f, 100f), 22.85f, Random.Range(200f, 270f));
        } else if (locationID == 2) {
            patrolDestination = new Vector3(Random.Range(130f, 230f), 12.5f, Random.Range(160f, 100f));
        } else {
            patrolDestination = new Vector3(Random.Range(150f, 230f), 17.65f, Random.Range(5f, 95f));
        }
        navAgent.destination = patrolDestination;
        distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
        distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
    }
}

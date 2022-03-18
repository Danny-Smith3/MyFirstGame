using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour {

    public Transform playerTransform;
    public Transform bombTransform;
    public NavMeshAgent navAgent;
    private Vector3 bloom = new Vector3(0.0785f, 0.0785f, 0.0785f);
    private int ammo = 30;
    private float fireRate = 5f;
    private float timeToFire = 0f;
    private bool isReloading = false;
    private bool travelingToDestination = true;
    private Vector3 patrolDestination;
    private float distanceToPlayer;
    private float distanceToPatrolTarget;
    private AudioManager audio;

    // Start is called before the first frame update
    void Start() {
        GameObject bomb = GameObject.Find("Bomb");
        GameObject player = GameObject.Find("Player");
        bombTransform = bomb.GetComponent<Transform>();
        playerTransform = player.GetComponent<Transform>();
        patrolDestination = new Vector3(Random.Range(-60f, 60f), bombTransform.position.y, bombTransform.position.z + Random.Range(-60f, 60f));
        navAgent.destination = patrolDestination;
        distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
        distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        audio = gameObject.GetComponent<AudioManager>();
        //start the walking sound it is looping
        audio.playSound("Walk");
    }

    // Update is called once per frame
    void Update() {
        if (isReloading) {
            return;
        }
        if (ammo == 0) {
            StartCoroutine(Reload());
            return;
        }
        distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        if (distanceToPlayer < 57.5f) {
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
            //roam near bomb
            distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
            if (distanceToPatrolTarget < 7f) {
                travelingToDestination = false;
            }
            if (!travelingToDestination) {
                patrolDestination = new Vector3(Random.Range(-60f, 60f), bombTransform.position.y, Random.Range(-60f, 60f));
                navAgent.destination = patrolDestination;
                distanceToPatrolTarget = Vector3.Distance(transform.position, patrolDestination);
                travelingToDestination = true;
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
        Shooting shot = gameObject.GetComponent<Shooting>();
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

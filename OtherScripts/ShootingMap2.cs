using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script handles the act of shooting for both the enemies and the player
//needs a direction, starting point, and a name of the one who fired the shot to activate
//the drawing of the trail after the shot was done with a tutorial

public class ShootingMap2 : MonoBehaviour {
    public TrailRenderer trail;
    public ParticleSystem impact;
    public int playerDamage = 20;

    public void Shoot(Vector3 direction, Vector3 position, string name) {
        if (Physics.Raycast(position, direction, out RaycastHit hit)) {
            TrailRenderer gunTrail = Instantiate(trail, position, Quaternion.identity);
            StartCoroutine(spawnTrail(gunTrail, hit));
            if (hit.transform.tag == "Enemy" && name == "Player") {
                HealthMap2 enemy = hit.transform.GetComponent<HealthMap2>();
                enemy.takeDamage(playerDamage);
            }
            if (hit.transform.name == "Player" && name == "Enemy") {
                PlayerHealthMap2 health = hit.transform.GetComponent<PlayerHealthMap2>();
                health.takeDamage(20);
            }
        }
    }

    //this part is from a tutorial; the tutorial is: Add Bullet Tracers To Your Hitscan Guns by Llam Academy
    private IEnumerator spawnTrail(TrailRenderer shotTrail, RaycastHit hit) {
        float time = 0f;
        Vector3 startPosition = shotTrail.transform.position;

        while (time < 1) {
            shotTrail.transform.position = Vector3.Lerp(startPosition, hit.point, time);
            time += Time.deltaTime / trail.time;
            yield return null;
        }
        shotTrail.transform.position = hit.point;
        Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));

        Destroy(shotTrail, trail.time);
    }
}

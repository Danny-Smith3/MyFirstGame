using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is basically the same as the other shooting script except that the enemy has a different health script for map3 because there are no keycards

public class ShootingMap3 : MonoBehaviour {
    public TrailRenderer trail;
    public ParticleSystem impact;
    public int playerDamage = 20;

    public void Shoot(Vector3 direction, Vector3 position, string name) {
        if (Physics.Raycast(position, direction, out RaycastHit hit)) {
            TrailRenderer gunTrail = Instantiate(trail, position, Quaternion.identity);
            StartCoroutine(spawnTrail(gunTrail, hit));
            if (hit.transform.tag == "Enemy" && name == "Player") {
                HealthMap3 enemy = hit.transform.GetComponent<HealthMap3>();
                enemy.takeDamage(playerDamage);
            }
            if (hit.transform.name == "Player" && name == "Enemy") {
                PlayerHealthMap3 health = hit.transform.GetComponent<PlayerHealthMap3>();
                health.takeDamage(20);
            }
        }
    }

    //this part is from a tutorial
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

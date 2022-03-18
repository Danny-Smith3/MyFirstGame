using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public TrailRenderer trail;
    public ParticleSystem impact;

    public void Shoot(Vector3 direction, Vector3 position, string name) {
        if (Physics.Raycast(position, direction, out RaycastHit hit)) {
            TrailRenderer gunTrail = Instantiate(trail, position, Quaternion.identity);
            StartCoroutine(spawnTrail(gunTrail, hit));
            if (hit.transform.tag == "Enemy" && name == "Player") {
                Health enemy = hit.transform.GetComponent<Health>();
                enemy.takeDamage(20);
            }
            if (hit.transform.name == "Player" && name == "Enemy") {
                PlayerHealth health = hit.transform.GetComponent<PlayerHealth>();
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

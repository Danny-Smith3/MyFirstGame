using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarImage : MonoBehaviour {

    private float startingPoint;

    void Start() {
        startingPoint = transform.position.x;
    }

    public void loseHealth() {
        transform.Translate(-30f, 0f, 0f);
        Vector3 temp = transform.localScale;
        temp.x -= .6f;
        transform.localScale = temp;
    }
    public void gainHealth() {
        transform.Translate(75f, 0f, 0f);
        Vector3 temp = transform.localScale;
        temp.x += 1.5f;
        transform.localScale = temp;
    }
    public void maxHealth() {
        Vector3 temp1 = transform.position;
        temp1.x = startingPoint;
        transform.position = temp1;
        Vector3 temp = transform.localScale;
        temp.x = 3f;
        transform.localScale = temp;
    }
}

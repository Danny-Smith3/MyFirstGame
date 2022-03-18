using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthBarImage : MonoBehaviour {
    public void loseHealth() {
        transform.Translate(-30f, 0f, 0f);
        Vector3 temp = transform.localScale;
        temp.x -= .6f;
        transform.localScale = temp;
    }
}

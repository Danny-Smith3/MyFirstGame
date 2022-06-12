using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I haven't done anything with this yet but this would handle recoil. Probably would do this after school is over if I wanted

public class Recoil : MonoBehaviour {

    private Transform camera;

    void Start() {
        camera = gameObject.GetComponent<Transform>();
    }

    public void addRecoil() {
        
    }

}

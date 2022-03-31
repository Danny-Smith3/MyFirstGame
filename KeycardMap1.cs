using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardMap1 : MonoBehaviour {

    private bool hasKeyCard;

    void Start() {
        hasKeyCard = false;
    }

    public void setKeyCard() {
        hasKeyCard = true;
    }

    public bool getKeyCard() {
        return hasKeyCard;
    }

}

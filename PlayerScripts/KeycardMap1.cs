using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//keeps track of inventory of keycard for player on map1

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

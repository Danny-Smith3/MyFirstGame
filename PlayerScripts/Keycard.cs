using UnityEngine;

//keeps track of inventory of keycards for player on map2

public class Keycard : MonoBehaviour {

    public bool hasKeyCard1;
    public bool hasKeyCard2;
    public bool hasKeyCard3;
    public bool hasKeyCard4;
    public bool hasBackpack;
    public bool hasHealable1;
    public bool hasHealable2;
    public bool hasHealable3;

    // Start is called before the first frame update
    void Start() {
        hasKeyCard1 = false;
        hasKeyCard2 = false;
        hasKeyCard3 = false;
        hasKeyCard4 = false;
        hasBackpack = false;
        hasHealable1 = false;
        hasHealable2 = false;
        hasHealable3 = false;
    }
}

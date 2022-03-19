using UnityEngine;

public class Keycard : MonoBehaviour {

    private bool hasKeyCard;

    // Start is called before the first frame update
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

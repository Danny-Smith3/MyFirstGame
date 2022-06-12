using UnityEngine;

//displayes the keycards for map2 doesn't follow enemies because they are in one set position to start the game
//this script is still necessary for this map because the keycard has to disappear once interacted with

public class ShowMap2 : MonoBehaviour {

    private bool isShowing;
    public MeshRenderer rend;
    public BoxCollider collider;

    // Start is called before the first frame update
    void Start() {
        isShowing = true;
        rend.enabled = true;
    }

    public void showKey(bool showing) {
        isShowing = showing;
        rend.enabled = showing;
        collider.enabled = showing;
    }
}

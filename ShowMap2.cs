using UnityEngine;

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

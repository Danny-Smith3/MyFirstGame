using UnityEngine;

public class Show : MonoBehaviour {

    public Transform enemy;
    private bool isEnemyAlive;
    private bool isShowing;
    public MeshRenderer rend;
    public BoxCollider collider;
    private Vector3 endPosition;

    // Start is called before the first frame update
    void Start() {
        transform.position = enemy.position;
        isEnemyAlive = true;
        isShowing = false;
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if (isEnemyAlive) {
            transform.position = enemy.position;
            endPosition = enemy.position;
        } else {
            transform.position = endPosition + new Vector3(0f, -2.0578f, 0f);
        }
    }

    public void showKey(bool showing) {
        isShowing = showing;
        rend.enabled = showing;
        collider.enabled = showing;
    }

    public void enemyAlive(bool enemyAlive) {
        isEnemyAlive = enemyAlive;
    }
}

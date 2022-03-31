using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int health = 100;
    public bool didWin;
    private bool eliminatedByEnemy = false;
    private bool gameOver = false;
    public TMP_Text healthText;
    public GameObject healthBarImage;
    private HealthBarImage healthBar;
    public PlayerMovement playerMovement;
    public GunScript gun;
    public Interact interactScript;

    void Start() {
        healthBar = healthBarImage.GetComponent<HealthBarImage>();
        healthText.text = "HP : 100";
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            didWin = false;
            eliminatedByEnemy = true;
            if (!gameOver) {
                StartCoroutine(EndGame());
            }
        }
    }

    public void takeDamage(int damage) {
        health -= damage;
        if (health >= 0) {
            healthText.text = "HP : " + health.ToString();
            healthBar.loseHealth();
        }
    }

    public void startEndGame() {
        StartCoroutine(EndGame());
    }

    private IEnumerator EndGame() {
        playerMovement.isAlive = false;
        gun.isAlive = false;
        interactScript.isAlive = false;
        yield return new WaitForSeconds(1f);
        GameObject gameManager = GameObject.Find("GameManager");
        GameOver game = gameManager.GetComponent<GameOver>();
        GameObject camera = GameObject.Find("MainCamera");
        Look lookScript = camera.GetComponent<Look>();
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies) {
            enemy.SetActive(false);
        }
        lookScript.gameOver();
        game.gameOver(didWin, eliminatedByEnemy);
        gameOver = true;
    }
}

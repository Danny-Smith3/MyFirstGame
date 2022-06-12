using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Collections;

//this script is for player health for map2
//needed seperate player health scripts for different maps because there are different interact scripts for different maps. The functionality other than that is the same
//updates the value of health in the UI. Also helps the healthBarImage script to update the healthbar
//Also shuts down a lot of things once the game is over so that there is no sound or interaction once the game panel shows up

public class PlayerHealthMap2 : MonoBehaviour {

    public int health = 100;
    public bool didWin;
    private bool eliminatedByEnemy = false;
    private bool gameOver = false;
    public TMP_Text healthText;
    public GameObject healthBarImage;
    private HealthBarImage healthBar;
    public PlayerMovement playerMovement;
    public GunScriptMap2 gun;
    public InteractMap2 interactScript;

    void Start() {
        healthBar = healthBarImage.GetComponent<HealthBarImage>();
        healthText.text = "HP : 100";
    }

    // Update is called once per frame
    void Update() {
        if (health <= 0) {
            healthText.text = "HP : 0";
            didWin = false;
            eliminatedByEnemy = true;
            if (!gameOver) {
                StartCoroutine(EndGame());
            }
        } else {
            healthText.text = "HP : " + health.ToString();
        }
    }

    public void takeDamage(int damage) {
        health -= damage;
        if (health >= 0) {
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

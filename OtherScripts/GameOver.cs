using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

//this script displays the game over panel and whatever outcome happened in the game

public class GameOver : MonoBehaviour {

    public GameObject gameOverPanel;
    public TMP_Text gameResultText;
    public TMP_Text descriptionOfGameText;
    public GameObject Minimap;

    public void gameOver(bool didWin, bool eliminatedByEnemy) {
        if (didWin) {
            gameResultText.text = "VICTORY!";
            descriptionOfGameText.text = "YOU DISABLED THE BOMB IN TIME";
        } else if (!eliminatedByEnemy) {
            gameResultText.text = "DEFEAT!";
            descriptionOfGameText.text = "THE BOMB EXPLODED";
        } else {
            gameResultText.text = "DEFEAT!";
            descriptionOfGameText.text = "YOU WERE ELIMINATED";
        }
        Minimap.SetActive(false);
        gameOverPanel.SetActive(true);
    }
}

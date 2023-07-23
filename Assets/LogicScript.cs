using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    [ContextMenu("Increase Speed")]
    public float increaseSpawnRate(float spawnRate)
    {
        Debug.Log("SPAWN RATE NOW AT " + spawnRate + " PLAYER SCORE " + playerScore);
        return 2;
    }

    [ContextMenu("Increase Speed")]
    public float increaseSpeed(float speedRate)
    {
        Debug.Log("SPEED RIGHT NOW AT " + speedRate + " PLAYER SCORE " + playerScore);
        return speedRate++;
    }
}

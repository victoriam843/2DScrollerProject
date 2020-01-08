using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript: MonoBehaviour
{
    public int playerLivesNum;
    public Text livesText;
    public Text scoreText;
    public Text endGameText;

    private float highScore;
    private int currentLives;
    private bool gameIsOn;

    // Start is called before the first frame update
    void Start()
    {
        RestartGame();
        
    }

    private void RestartGame()
    {
        currentLives = playerLivesNum;
        gameIsOn = true;

        livesText.text = "LIVES: " + currentLives;
        highScore = 0;

        endGameText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsOn)
        {
            highScore += Time.deltaTime * (10);
            scoreText.text = "SCORE: " + System.Math.Round(highScore, 1);
        }
       



        if (Input.GetKeyDown("r"))
        {
            RestartGame();
        }
    }

    public void UpdatePlayerLives(int amount)
    {
        if (!gameIsOn)
            return;

        currentLives += amount;
        Debug.Log("LIVES: " + currentLives);
        livesText.text = "LIVES: " + currentLives;

        if (currentLives <= 0)
        {
            gameIsOn = false;
            Debug.Log("game is over");
            endGameText.text = "game is over";
        }
    }


    
}

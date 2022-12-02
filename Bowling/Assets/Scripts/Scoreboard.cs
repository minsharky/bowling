using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public static Scoreboard Singleton;

    public static void ScorePoints(int points)
    {
        Singleton.ScorePointsInternal(points);
    }
    public static void GameOver()
    {
        Singleton.GameOverInternal();
    }

    public static void GameWin()
    {
        Singleton.GameWinInternal();
    }

    public int Score;
    public int GameWinScore; 
    private TMP_Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Singleton = this;
        scoreDisplay = GetComponent<TMP_Text>();
        GameWinScore = 20;
        // Initialize the display
        ScorePointsInternal(0);
    }

    private void ScorePointsInternal(int points)
    {
        Score += points;
        if (Score >= GameWinScore)
        {
            GameWin();
        }
        else
        {
            scoreDisplay.text = "Score: " + Score.ToString();
        }
    }

    private void GameOverInternal()
    {
        Time.timeScale = 0;
        scoreDisplay.text = "You Lose / OOPS";
    }

    private void GameWinInternal()
    {
        Time.timeScale = 0;
        scoreDisplay.text = "You Win!";
    }
}

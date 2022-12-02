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

    public int Score;

    private TMP_Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Singleton = this;
        scoreDisplay = GetComponent<TMP_Text>();
        // Initialize the display
        ScorePointsInternal(0);
    }

    private void ScorePointsInternal(int points)
    {
        Score += points;
        scoreDisplay.text = "Score: " + Score.ToString();
    }
}

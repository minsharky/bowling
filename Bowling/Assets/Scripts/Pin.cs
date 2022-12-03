using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool scored = false;
    private float pinThreshold = -3.5f;
    public static int pointPerPin = 1;
        
    void Update()
    {
        if (transform.position.y < pinThreshold && !scored)
        {
            scored = true;
            Scoreboard.ScorePoints(pointPerPin);
        }
    }
}

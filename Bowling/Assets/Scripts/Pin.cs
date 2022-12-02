using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool scored = false;
    
    private float pinThreshold = -3.5f;

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.GetComponent<Ball>() != null)
    //     {
    //         // destroy after all of the pins stop moving
    //         // add points to scoreboard
    //         Scoreboard.ScorePoints(1);
    //     }
    // }

    void Update()
    {
        if (transform.position.y < pinThreshold && !scored)
        {
            scored = true;
            Scoreboard.ScorePoints(1);
        }

    }
}

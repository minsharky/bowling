    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>() != null) {
            // destroy after all of the pins stop moving
            // add points to scoreboard
            Scoreboard.ScorePoints(1);
        }
    }
}

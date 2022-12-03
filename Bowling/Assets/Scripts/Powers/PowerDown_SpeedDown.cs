using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown_SpeedDown : MonoBehaviour
{
    Ball ball;

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            ball.ActivateSpeedPowerDown();
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown_ScoreDiv : MonoBehaviour
{
    public int pointPerPin = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            Pin.pointPerPin = pointPerPin;
            Destroy(gameObject);
        }
    }

}

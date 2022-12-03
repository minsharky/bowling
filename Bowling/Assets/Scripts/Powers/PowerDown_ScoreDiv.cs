using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown_ScoreDiv : MonoBehaviour
{
    public int pointPerPin = 1;
    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            sound.Play();
            Pin.pointPerPin = pointPerPin;
            Destroy(gameObject);
        }
    }

}

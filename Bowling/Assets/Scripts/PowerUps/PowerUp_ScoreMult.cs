using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_ScoreMult : MonoBehaviour
{
    public int scoreMultiplier = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player") { 
            Destroy(other.gameObject);
            GetComponent<Pin>().pointPerPin *= scoreMultiplier;
        }
    }
}

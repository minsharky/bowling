using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDown_GetSmaller : MonoBehaviour
{
    public Vector3 scale = new Vector3(1.5f, 1.5f, 1.5f);
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.GetComponent<Ball>() != null) {
            other.transform.localScale = scale;
            Destroy(gameObject);
        }
    }
}

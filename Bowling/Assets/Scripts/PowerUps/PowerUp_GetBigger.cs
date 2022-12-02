using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_GetBigger : MonoBehaviour
{
    public Vector3 scale = new Vector3(2.5f, 2.5f, 2.5f);
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Ball>() != null)
        {
            other.transform.localScale += scale;
            Destroy(gameObject);
        }
    }
}

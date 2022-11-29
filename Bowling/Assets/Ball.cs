using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody BallRB;

    // Start is called before the first frame update
    void Start()
    {
        BallRB = GetComponent<Rigidbody>();
        BallRB.AddForce(new Vector3(0, 0, 500));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

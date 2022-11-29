using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody BallRB;
    private bool launched;
    private int maxRot = 10;
    public int rotSpeed = 1;
    public int ballForce = 100;

    // Start is called before the first frame update
    void Start()
    {
        BallRB = GetComponent<Rigidbody>();
        launched = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Use left/right arrows to angle ball left/right
        //Xlocal = transform.right;
        //Ylocal = transform.up;
        //Zlocal = transform.forward;

        if (!launched)
        {
            bool left = Input.GetKeyDown(KeyCode.LeftArrow);
            bool right = Input.GetKeyDown(KeyCode.RightArrow);
            if (left)
            {
                BallRB.MoveRotation(Quaternion.Euler(0, -rotSpeed * maxRot, 0));
            }
            if (right)
            {
                BallRB.MoveRotation(Quaternion.Euler(0, rotSpeed * maxRot, 0));
            }
        }

        //use spacebar to launch ball forward
        if (Input.GetKey(KeyCode.Space))
        {
            launched = true;
            BallRB.AddForce(transform.forward * ballForce);
        }
    }
}

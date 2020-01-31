using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float dashSpeed = 20;
    public float dashDur = 5;
    float dashCounter;
    Rigidbody2D rb;
    Move move;

    bool dashKey;

    // Start is called before the first frame update
    void Start()
    {
        dashKey = false;
        rb = GetComponent<Rigidbody2D>();
        move = GetComponent<Move>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        dashKey = true;
    }

    void FixedUpdate()
    {
        if (dashKey && dashCounter == 0)
        {
            dashCounter = dashDur;
            dashKey = false;
        }
        if (dashCounter >0)
        {
            dash();
            move.enabled = false;
            dashCounter--;
            if(dashCounter == 0)
            {
                move.enabled = true;
            }
        }
        
    }

    public void dash()
    {
        Vector3 v;
        if (move.facingRight)
        {
            v = Vector3.right * dashSpeed;
        }
        else
        {
            v = Vector3.right * dashSpeed * -1;
        }
        
        rb.velocity = (v);
    }
}

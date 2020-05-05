using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float climbSpeed;
    public void climb(float input, bool vertical)
    {
        Vector2 newVelocity = Vector2.zero;
        if(vertical)
        {
            newVelocity.y = input * climbSpeed;
        }
        else
        {
            newVelocity.x = input * climbSpeed;
        }
        rb.velocity = newVelocity;
    }


}

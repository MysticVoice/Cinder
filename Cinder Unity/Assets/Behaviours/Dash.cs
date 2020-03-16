using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float dashSpeed = 20;
    public int dashDur = 5;
    public int cooldownDur = 15;
    float dashCounter;
    int cooldown;
    Rigidbody2D rb;
    Move move;

    void Start()
    {
        cooldown = 0;
        rb = GetComponent<Rigidbody2D>();
        move = GetComponent<Move>();
    }

    public void dash(bool dashInput)
    {
        if (cooldown == 0)
        {
            if (dashInput && dashCounter == 0)
            {
                dashCounter = dashDur;
                dashInput = false;
                cooldown = cooldownDur;
            }
        }
        else
        {
            dashInput = false;
            cooldown--;
        }
        if (dashCounter > 0)
        {
            useDash();
            move.enabled = false;
            dashCounter--;
            if (dashCounter == 0)
            {
                move.enabled = true;
            }
        }
    }

    public void useDash()
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

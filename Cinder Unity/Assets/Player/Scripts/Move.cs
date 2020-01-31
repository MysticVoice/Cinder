using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    
    public float movementSpeed = 0.1f;
    private float lerpRate = 0.1f;
    private float moveInput;
    Rigidbody2D rb;

    [HideInInspector]
    public bool facingRight;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Vector2 newSpeed = new Vector2(moveInput * movementSpeed, rb.velocity.y);
        rb.velocity = newSpeed;
        if(moveInput < 0)
        {
            facingRight = false;
        }
        else
        {
            facingRight = true;
        }
        
    }
}

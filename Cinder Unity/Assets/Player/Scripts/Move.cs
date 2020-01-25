using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    
    public float movementSpeed = 0.1f;
    private float lerpRate = 0.1f;
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 newSpeed = new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed, rb.velocity.y,0);
        rb.velocity = newSpeed;
        //rb.velocity = Vector2.Lerp(rb.velocity,newSpeed,lerpRate);
        //Debug.Log(rb.velocity);
        
    }
}

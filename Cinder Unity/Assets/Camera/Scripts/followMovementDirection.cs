using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMovementDirection : MonoBehaviour
{
    public Rigidbody2D rb;
    public float leadDistance = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 v = rb.velocity* leadDistance;
        transform.position = rb.transform.position + v;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMovementDirection : MonoBehaviour
{
    Rigidbody2D rb;
    public float leadDistance = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = rb.velocity * leadDistance;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestHeldItem : HeldItem
{
    public override float weight => 1;

    public override void useItem()
    {
        GameObject g = Instantiate(this.gameObject);
        g.transform.position = this.transform.position;
        g.GetComponent<Rigidbody2D>().simulated = true;
    }
}
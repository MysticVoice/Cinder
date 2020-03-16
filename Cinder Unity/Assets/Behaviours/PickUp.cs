using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Collider2D touchingItem;

    public Transform world;
    public LayerMask whatIsPickup;
    public Transform checkPosition;
    public float checkRadius;

    public void dropItem(HeldItem item)
    {
        item.transform.parent = world;
        Rigidbody2D rb = item.transform.GetComponent<Rigidbody2D>();
        rb.simulated = true;
    }

    public HeldItem pickupItem(Transform holdPos)
    {
        touchingItem = Physics2D.OverlapCircle(checkPosition.position, checkRadius, whatIsPickup);
        if (touchingItem != null)
        {
            touchingItem.transform.parent = holdPos.transform;
            touchingItem.transform.localPosition = holdPos.localPosition;
            Rigidbody2D rb = touchingItem.GetComponent<Rigidbody2D>();
            rb.simulated = false;
            return touchingItem.GetComponent<HeldItem>();
        }
        return null;
    }
}

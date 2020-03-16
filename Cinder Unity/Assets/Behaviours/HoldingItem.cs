using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingItem: MonoBehaviour
{
    private HeldItem heldItem;
    public Transform holdPosition;
    private PickUp pickup;

    void Awake()
    {
        pickup = GetComponent<PickUp>();
    }


    public void useItem()
    {
        if(heldItem!= null) heldItem.useItem();
    }

    public void pickupOrDrop()
    {
        if(heldItem != null)
        {
            pickup.dropItem(heldItem);
            heldItem = null;
        }
        else
        {
            heldItem = pickup.pickupItem(holdPosition);
        }
    }
}

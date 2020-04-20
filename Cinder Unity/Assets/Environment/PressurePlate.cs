using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : InteractableTrigger
{
    List<Collider2D> activators = new List<Collider2D>();

    void OnTriggerEnter2D(Collider2D other)
    {
        activators.Add(other);
        setActiveState(true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        activators.Remove(other);
        if(activators.Count == 0)
        {
            setActiveState(false);
        }
    }
}

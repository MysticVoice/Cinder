using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : InteractableTrigger
{
    
    private bool playerInRange = false;
    private bool interact = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if(!interact) interact = Input.GetButtonDown("interact");
    }

    void FixedUpdate()
    {
        if(playerInRange && interact)
        {
            setActiveState(!getActiveState());
        }
        interact = false;
    }

}

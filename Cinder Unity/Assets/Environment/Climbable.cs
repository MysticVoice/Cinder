using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbable : InteractableTrigger
{
    public PlayerControler player;
    public bool vertical;
    private bool playerInRange = false;
    private bool interact = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
            Debug.Log("Player Detected!");
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
        if (!interact) interact = Input.GetButtonDown("interact");
    }

    void FixedUpdate()
    {
        if (playerInRange && interact)
        {
            setActiveState(!getActiveState());
            if(getActiveState())
            {
                player.climbingObject = this;
            }
            else
            {
                player.climbingObject = null;
            }
        }
        if (!playerInRange && getActiveState())
        {
            setActiveState(!getActiveState());
            player.climbingObject = null;
        }
        interact = false;
    }

    public void letGo()
    {
        setActiveState(false);
        player.climbingObject = null;
    }
}

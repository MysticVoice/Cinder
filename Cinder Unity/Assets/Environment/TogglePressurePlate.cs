using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePressurePlate : InteractableTrigger
{
    
    float cooldown = 0;
    public float cooldownDur = 0.5f;
    void OnTriggerEnter2D()
    {
        if (cooldown < Time.time)
        {
            cooldown = Time.time + cooldownDur;
            setActiveState(!getActiveState());
        }
    }
}

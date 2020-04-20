using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : MonoBehaviour
{
    public bool state;

    public bool getActiveState()
    {
        return state;
    }
    public void setActiveState(bool state)
    {
        this.state = state;
    }
}

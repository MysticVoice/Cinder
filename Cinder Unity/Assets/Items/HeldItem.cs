using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeldItem : MonoBehaviour
{
    public abstract float weight
    {
        get;
    }
    public abstract void useItem();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger Detected");
        if (other.tag == "Player")
        {
            Debug.Log("Damage done");
            Health health = other.gameObject.GetComponent<Health>();
            health.damage(damage);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage;
    bool takeDamage;
    Collider2D player;

    void Awake()
    {
        takeDamage = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            takeDamage = true;
            player = other;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            takeDamage = false;
            player = null;
        }
    }

    void FixedUpdate()
    {
        if(takeDamage)
        {
            Health health = player.gameObject.GetComponent<Health>();
            health.damage(damage);
        }
    }
}

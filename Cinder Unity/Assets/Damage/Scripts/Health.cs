using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text t;
    public int maxHealth;
    private int currentHealth;
    public int healthTickCount = 10;
    private int currentTick = 0;
    public float regenAmmount = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        //t.text = "Health: " + currentHealth;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTick++;
        if(currentTick >= healthTickCount)
        {
            regenBasedOnHp();
            currentTick = 0;
        }
    }

    public void damage(int damage)
    {
        currentHealth -= damage;
        //t.text = "Health: " + currentHealth;
        if (currentHealth<=0)
        {
            die();
        }
    }

    public int getCurrentHealth()
    {
        return currentHealth;
    }

    private void die()
    {
        Destroy(this.gameObject);
    }
    
    private void regenBasedOnHp()
    {
        currentHealth += (int)(regenAmmount *(1f / ((float)currentHealth / (float)maxHealth)));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text t;
    public int maxHealth;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        t.text = "Health: " + currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(int damage)
    {
        currentHealth -= damage;
        t.text = "Health: " + currentHealth;
        if (currentHealth<=0)
        {
            die();
        }
    }
    
    private void die()
    {
        Destroy(this.gameObject);
    }
}

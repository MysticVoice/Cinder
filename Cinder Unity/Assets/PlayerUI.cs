using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Slider healthBar;
    private PlayerControler p;
    private int health => p.health.getCurrentHealth();
    private int maxHealth => p.health.maxHealth;

    void Awake()
    {
        p = GetComponent<PlayerControler>();
    }

    void Update()
    {
        float healthPercentage = (float)health / (float)maxHealth;
        healthBar.value = healthPercentage;
    }

}

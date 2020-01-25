using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    /*public int maxHealth;
    public int maxStamina;
    public int maxMana;

    private int currentHealth;
    private int currentStamina;
    private int currentMana;

    public int regenerate(int regenAmmount, int maxPossible,int stat)
    {
        if (stat + regenAmmount <= maxPossible)
        {
            stat += regenAmmount;
        }
        else
        {
            stat = maxPossible;
        }
        return stat;
    }

    public void regenMana(int mana)
    {
        currentMana = regenerate(mana,maxMana,currentMana);
    }
    public void regenHealth(int health)
    {
        currentHealth = regenerate(health,maxHealth,currentHealth);
    }
    public void regenStamina(int stamina)
    {
        currentStamina = regenerate(stamina,maxStamina,currentStamina);
    }*/

    public int maxFlame = 200;
    public int currentFlame
    {
        get { return currentFlame; }
        set { currentFlame = value; }
    }


    public PlayerData(int maxFlame)
    {
        this.maxFlame = maxFlame;
        currentFlame = maxFlame;
    }

    public PlayerData(int maxFlame,int currentFlame)
    {
        this.maxFlame = maxFlame;
        this.currentFlame = currentFlame;
    }

    public void regenerate(int flame)
    {
        if(currentFlame+flame<=maxFlame)
        {
            currentFlame += flame;
        }
        else
        {
            currentFlame = maxFlame;
        }
    }

    //returns true if dead
    public bool damage(int damage)
    {
        if(currentFlame-damage >0)
        {
            currentFlame -= damage;
            return false;
        }
        else
        {
            currentFlame = 0;
            return true;
        }
    }
}

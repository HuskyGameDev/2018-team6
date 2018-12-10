using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem  {

    public int health;
    public int healthMax;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    //gets the current level of health
    public int getHealth()
    {
        return health;
    }
	
    // deals damage to the subject 
    public void damage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 0)
        {
            health = 0;
        }
    }

    // heals the subject
    public void heal(int healAmount)
    {
        health += healAmount;
        if(health > healthMax)
        {
            health = healthMax;
        }
    }


}
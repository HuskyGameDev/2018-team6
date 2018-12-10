using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem  {

    private int health;
    private int healthMax;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int getHealth()
    {
        return health;
    }
	
    public void damage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 0)
        {
            health = 0;
        }
    }
    public void heal(int healAmount)
    {
        health += healAmount;
        if(health > healthMax)
        {
            health = healthMax;
        }
    }


}
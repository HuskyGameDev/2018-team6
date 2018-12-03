using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HealthSystem enemy = new HealthSystem(100);
       // MeleeManager melee = new MeleeManager();

      /*
        if (melee.punch == true)
        {
            Debug.Log("Health: " + enemy.getHealth());
            enemy.damage(10);
        }
        Debug.Log("Health: " + enemy.getHealth());
        
        */
        

    }


}

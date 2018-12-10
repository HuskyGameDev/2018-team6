using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HealthSystem healthSystem = new HealthSystem(100);
        Debug.Log("Health: " + healthSystem.getHealth());
        healthSystem.damage(10);
        Debug.Log("Health: " + healthSystem.getHealth());
        healthSystem.heal(10);
        Debug.Log("Health: " + healthSystem.getHealth());

    }


}

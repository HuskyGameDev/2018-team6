using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public HealthSystem playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnStart = 3f;           // How long before enemies start to spawn.
    public float spawnTime = 3f;            // How long between enemy spawns
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    public const int enemyCap = 30;         // Max amount of enemies allowed on-screen.
    public int enemyCounter = 0;            // The current amount of enemies on-screen.
    public float timer = 0f;                // The amount of time that has passed since the start of the level.
    public const float endTime = 120f;      // The time denoting the end of the round.

    void Start()
    {
        // Call the Spawn function after a delay of the spawnStart and then continue to call after the spawnTime amount of time.
        InvokeRepeating("Spawn", spawnStart, spawnTime);
    }


    void Spawn()
    {
        // If the player has no health left...
        /* if (playerHealth.getHealth() <= 0f)
        {
            // ... exit the function.
            return;
        } */

        // If there are 30 or more enemies on the screen or timer is greater than the endTime...
        if (enemyCounter >= enemyCap || timer > endTime)
        {
            // ... exit the function.
            return;
        }

        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        // increment the counter by one
        enemyCounter++;
    }

    // need to add something to allow us to decrement the enemyCounter when an enemy dies.
}
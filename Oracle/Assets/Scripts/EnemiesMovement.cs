using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{

    public float speed = 0.005f; //initialize speed
    public GameObject player; //declare player GameObject
    private Rigidbody rb; //declare ridgebody

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //initialize player
        rb = GetComponent<Rigidbody>(); //initialize player

        if (!player) //if player object does not exist
            Debug.Log("ERROR could not find Player!"); 
    }

    void Update()
    {
        if (!player) return; //if player object does not exist 

        var distance = Vector3.Distance(player.transform.position, transform.position); //initializes distance to the distance between the player and the enemy

        if (distance < 60)  //if the distance between enemy and player is less than 60
        {
            Debug.Log("player is close");

            Vector3 delta = player.transform.position - transform.position; //initializes vector to the the distance between the enemy and player

            float moveSpeed = (speed * Time.deltaTime); //sets the speed of the movement

            Vector3 xDifference = new Vector3(0,0,0); //initializes xDifference 
            Vector3 yDifference = new Vector3(0, 0, 0); //initializes yDifference
            Vector3 zDifference = new Vector3(0, 0, 0); //initializes zDifference
            Vector3 finalVector = new Vector3(0, 0, 0); //initializes finalVector

            if (transform.position.x - player.transform.position.x == 0) //if the x difference between player and enemy is 0, set position
            {
                xDifference = new Vector3(0,0,0);
            }

            if (transform.position.x - player.transform.position.x > 0) //if the x difference between player and enemy is > 0, set position
            {
                xDifference = new Vector3(-speed, 0, 0);
            }

            if (transform.position.x - player.transform.position.x < 0) //if the x difference between player and enemy is < 0, set position
            {
                xDifference = new Vector3(speed, 0, 0);
            }

            if (transform.position.y - player.transform.position.y == 0) //if the y difference between player and enemy is is 0, set position
            {
                yDifference = new Vector3(0, 0, 0);
            }

            if (transform.position.y - player.transform.position.y > 0) //if the y difference between player and enemy is > 0, set position
            {
                yDifference = new Vector3(0, -speed, 0);
            }

            if (transform.position.y - player.transform.position.y < 0) //if the y difference between player and enemy is < 0, set position
            {
                yDifference = new Vector3(0, speed, 0);
            }

            if (transform.position.z - player.transform.position.z == 0) //if the z difference between player and enemy is 0, set position
            {
                zDifference = new Vector3(0, 0, 0);
            }

            if (transform.position.z - player.transform.position.z > 0) //if the z difference between player and enemy is > 0, set position
            {
                zDifference = new Vector3(0, 0, -speed);
            }

            if (transform.position.z - player.transform.position.z < 0) //if the z difference between player and enemy is < 0, set position
            {
                zDifference = new Vector3(0, 0, speed);
            }

            finalVector = xDifference + yDifference + zDifference;

            transform.position = transform.position + finalVector;
            //transform.SetPositionAndRotation(delta * moveSpeed /*Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z)*/, new Quaternion());
        }
        else //when player not close enough
        {
            Debug.Log("not close yet " + distance);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{

    float speed = 0.001f;                                                                               //sets speed
    GameObject player = new GameObject();                                                               //initialize player 
    private Rigidbody rb;                                                                               //declare rigidbody

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");                                            //associating object with player sprite
        rb = GetComponent<Rigidbody>();                                                                 //sets the rigidbody 

        if (!player)                                                                                    //if not player, errror message
            Debug.Log("ERROR could not find Player!");

    }

    void Update()
    {
        if (!player) return;                                                                           //if there's no player, don't do anything

        var distance = Vector3.Distance(player.transform.position, transform.position);                //sets the difference

        if (distance < 60)                                                                             //if distance is less than 60
        {
            Debug.Log("player is close");                                                              //error messager 

            Vector3 delta = player.transform.position - transform.position;                            //set delta vector

            float moveSpeed = (speed * Time.deltaTime);                                               //set movement speed

            Vector3 xDifference = new Vector3(0,0,0);                                                 //initialize xDifference
            Vector3 yDifference = new Vector3(0, 0, 0);                                               //initialize yDifference 
            Vector3 finalVector = new Vector3(0, 0, 0);                                               //initialize finalVector

            if (transform.position.x - player.transform.position.x == 0)                              //if enemy x - player x = 0
            {
                xDifference = new Vector3(0,0,0);
            }

            if (transform.position.x - player.transform.position.x > 0)                               //if enemy x - player x > 0
            {
                xDifference = new Vector3(-0.5f, 0, 0);
            }

            if (transform.position.x - player.transform.position.x < 0)                               //if enemy x - player x < 0
            {
                xDifference = new Vector3(0.5f, 0, 0);
            }

            if (transform.position.z - player.transform.position.z == 0)                              //if enemy y - player y = 0
            {
                yDifference = new Vector3(0, 0, 0);
            }

            if (transform.position.z - player.transform.position.z > 0)                              //if enemy y - player y > 0
            {
                yDifference = new Vector3(0, -0.5f, 0);
            }

            if (transform.position.z - player.transform.position.z < 0)                              //if enemy y - player y < 0
            {
                yDifference = new Vector3(0, 0.5f, 0);
            }

            finalVector = xDifference + yDifference;                                                 //sets finalVector to xDifference + yDifference

            transform.position = transform.position + finalVector;
            //transform.SetPositionAndRotation(delta * moveSpeed /*Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z)*/, new Quaternion());
        }
        else
        {
            Debug.Log("not close yet " + distance);
        }
    }

        /*void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            rb.AddForce(movement * speed);
        }*/
}

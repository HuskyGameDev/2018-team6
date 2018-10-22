using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{

    float speed = 0.001f;
    GameObject player = new GameObject();
    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();

        if (!player)
            Debug.Log("ERROR could not find Player!");

    }

    void Update()
    {
        if (!player) return;

        var distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < 60)
        {
            Debug.Log("player is close");

            Vector3 delta = player.transform.position - transform.position;

            float moveSpeed = (speed * Time.deltaTime);

            Vector3 xDifference = new Vector3(0,0,0);
            Vector3 yDifference = new Vector3(0, 0, 0);
            Vector3 finalVector = new Vector3(0, 0, 0);

            if (transform.position.x - player.transform.position.x == 0)
            {
                xDifference = new Vector3(0,0,0);
            }

            if (transform.position.x - player.transform.position.x > 0)
            {
                xDifference = new Vector3(-0.5f, 0, 0);
            }

            if (transform.position.x - player.transform.position.x < 0)
            {
                xDifference = new Vector3(0.5f, 0, 0);
            }

            if (transform.position.y - player.transform.position.y == 0)
            {
                yDifference = new Vector3(0, 0, 0);
            }

            if (transform.position.y - player.transform.position.y > 0)
            {
                yDifference = new Vector3(0, -0.5f, 0);
            }

            if (transform.position.y - player.transform.position.y < 0)
            {
                yDifference = new Vector3(0, 0.5f, 0);
            }

            finalVector = xDifference + yDifference;

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

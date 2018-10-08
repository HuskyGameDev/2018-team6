using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{

    float speed = 1;
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

            transform.position = transform.position + (delta * moveSpeed);
            transform.SetPositionAndRotation(delta * moveSpeed /*Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z)*/, new Quaternion());

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

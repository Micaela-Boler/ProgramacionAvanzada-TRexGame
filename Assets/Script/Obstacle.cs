using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;


    void Update()
    {
        ObstacleMovement();
    }


    void ObstacleMovement()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
            gameObject.SetActive(false);
    }
}

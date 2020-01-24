using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float movementSpeed = 2.0f;
    public float aggroDistance = 8.0f;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        float distance = distanceFromPlayer();
        if(distance < aggroDistance)
        {
            moveTowardsPlayer();
        }
    }

    float distanceFromPlayer() //Determines wether to chase player based on distance from player
    {
        float distance = player.transform.position.x - this.transform.position.x;
        if (distance < 0)
        {
            distance *= -1;
        }
        return distance;
    }

    void moveTowardsPlayer()
    {
        //X Correction
        if (this.transform.position.x < player.transform.position.x)
        {
            this.transform.position = new Vector3(this.transform.position.x + 1 * movementSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x > player.transform.position.x)
        {
            this.transform.position = new Vector3(this.transform.position.x - 1 * movementSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        //Y Correction
        if (this.transform.position.y < player.transform.position.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1 * movementSpeed * Time.deltaTime, this.transform.position.z);
        }
        if (this.transform.position.y > player.transform.position.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 1 * movementSpeed * Time.deltaTime, this.transform.position.z);
        }
    }
}

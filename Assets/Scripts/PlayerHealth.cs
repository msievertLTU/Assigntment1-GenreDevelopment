using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    void OnTriggerEnter(Collider collider)
    {
        BoxCollider enemy = collider.gameObject.GetComponent<BoxCollider>();
        GameObject player = collider.gameObject.GetComponent<GameObject>();

        if (enemy != null)
        {
            if (enemy.tag == "Enemy")
            {

                health -= 1;

                if (health <= 2)
                {
                    heart1.transform.position = new Vector3(heart1.transform.position.x, heart1.transform.position.y - 10, heart1.transform.position.z);
                }
                if (health <= 1)
                {
                    heart2.transform.position = new Vector3(heart2.transform.position.x, heart2.transform.position.y - 10, heart2.transform.position.z);
                }
                if (health <= 0)
                {
                    PlayerScript playerDestroy = FindObjectOfType<PlayerScript>();
                    playerDestroy.OnDestroy();
                    heart3.transform.position = new Vector3(heart3.transform.position.x, heart3.transform.position.y - 10, heart3.transform.position.z);
                }

            }
        }
    }
}

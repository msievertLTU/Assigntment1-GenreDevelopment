using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float health = 2.0f;
    public bool isEnemy = true;

    void OnTriggerEnter(Collider collider)
    {
        BulletScript bullet = collider.gameObject.GetComponent<BulletScript>();

        if (bullet != null)
        {
            if (bullet.isEnemyShot = isEnemy)
            {
                health -= bullet.bulletDamage;

                //Moves bullets offscreen to be destroyed instead of staying stationary at impact point.
                bullet.transform.position = new Vector3(bullet.transform.position.x, bullet.transform.position.y - 100, bullet.transform.position.z);
                Destroy(bullet);

                if (health <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}

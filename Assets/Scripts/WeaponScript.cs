using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    public Transform bulletPrefab;
    public float shootingRate = 0.50f;
    private float bulletTimer;

    void Start()
    {
        bulletTimer = 0f;
    }

    void Update()
    {
        if (bulletTimer > 0)
        {
            bulletTimer -= Time.deltaTime;
        }
    }

    public void Shoot(bool isEnemy)
    {
        if (attackAvailable() == 1)
        {
            bulletTimer = shootingRate;

            var newBullet = Instantiate(bulletPrefab);

            newBullet.position = transform.position;

            BulletScript bullet = newBullet.gameObject.GetComponent<BulletScript>();
        }
    }

    int attackAvailable() {
        if (bulletTimer <= 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}

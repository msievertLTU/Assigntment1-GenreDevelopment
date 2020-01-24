using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{

    public Transform bulletPrefab;
    public float shootingRate = 0.25f;
    private float bulletCooldown;

    void Start()
    {
        bulletCooldown = 0f;
    }

    void Update()
    {
        if (bulletCooldown > 0)
        {
            bulletCooldown -= Time.deltaTime;
        }
    }

    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            bulletCooldown = shootingRate;

            var newBullet = Instantiate(bulletPrefab);

            newBullet.position = transform.position;

            BulletScript bullet = newBullet.gameObject.GetComponent<BulletScript>();
            if (bullet != null)
            {
                bullet.isEnemyShot = isEnemy;
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return bulletCooldown <= 0f;
        }
    }
}

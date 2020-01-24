using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float jumpForce = 5.0f;
    public bool isFiring = false;

    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        //Sets sprite to SpriteRenderer component of player.
        sprite = GetComponent<SpriteRenderer>();
    }

    void Fire()
    {
        WeaponScript weapon = GetComponent<WeaponScript>();
        if (weapon != null)
        {
            weapon.Attack(false);
        }
    }

    public void OnDestroy()
    {
        var gameLost = FindObjectOfType<GameLostScript>();
        gameLost.ShowButtons();
        Destroy(this);
    }

    public void Move()
    {
        //Horizontal and Vertical movement control for Player
        float xMov = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x + xMov, this.transform.position.y, this.transform.position.z);

        float jump = Input.GetAxis("Up") * jumpForce * Time.deltaTime;
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + jump, this.transform.position.z);

        //Determines if Player is moving left or right then rotates sprite accordingly.
        if (xMov < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Space") > 0)
        {
            Fire();
        }

        Move();

    }
}

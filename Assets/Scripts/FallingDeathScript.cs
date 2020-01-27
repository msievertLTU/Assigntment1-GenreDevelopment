using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeathScript : MonoBehaviour
{
    public GameObject box;
    public GameObject player;
    public PlayerScript playerScript;

    void Start()
    {
        playerScript = player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < box.transform.position.y)
        {
            //playerScript.health = 0;
            playerScript.OnDestroy();
        }
        
    }
}

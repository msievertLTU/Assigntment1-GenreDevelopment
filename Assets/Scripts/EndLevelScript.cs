using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour
{
    //public GameObject player;
    //public GameObject flag;

    // Start is called before the first frame update
    void Start()
    {
        //flag = GetComponent<GameObject>();
        
    }

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Victory");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

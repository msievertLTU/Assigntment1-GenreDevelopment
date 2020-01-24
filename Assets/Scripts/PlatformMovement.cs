using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float positionOne = 0.0f;
    public float positionTwo = 0.0f;

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x <= positionOne)
        {
            moveSpeed = -1 * moveSpeed;
        }
        if (this.transform.position.x >= positionTwo)
        {
            moveSpeed = -1 * moveSpeed;
        }
        this.transform.position = new Vector3(this.transform.position.x + moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float positionOne = 0.0f;
    public float positionTwo = 0.0f;
    float switchDirectionTimer = 10.0f;

    // Update is called once per frame
    void Update()
    {
        switchDirectionTimer -= 1.0f;

        if (this.transform.position.x <= positionOne && switchDirectionTimer <= 0)
        {
            moveSpeed = -1 * moveSpeed;
            switchDirectionTimer = 10.0f;
        }
        if (this.transform.position.x >= positionTwo && switchDirectionTimer <= 0)
        {
            moveSpeed = -1 * moveSpeed;
            switchDirectionTimer = 10.0f;
        }
        this.transform.position = new Vector3(this.transform.position.x + moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
    }

}

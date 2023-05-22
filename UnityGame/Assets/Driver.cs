using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    float moveSpeed = 0.4f;
    float steerSpeed = 1f;
    void Start()
    {

    }
    void Update()
    {
        float moveVelocity = -Input.GetAxis("Vertical") * moveSpeed;
        float steeringVelocity = Input.GetAxis("Horizontal") * steerSpeed;
        transform.Rotate(0, 0, steeringVelocity);
        transform.Translate(0, moveVelocity, 0);
    }
}

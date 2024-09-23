using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 10f;
    public float tiltAngle = -5f;

    void Update() {
        // Calculate the forward direction with the tilt
        Vector3 forwardDirection = Quaternion.Euler(tiltAngle, 0, 0) * Vector3.forward;
        
        // Move the ship in the adjusted forward direction
        transform.Translate(forwardDirection * speed * Time.deltaTime);
    }
}

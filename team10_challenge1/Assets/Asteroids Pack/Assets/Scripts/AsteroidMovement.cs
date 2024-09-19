using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 2f;          // Speed of the asteroid
    private Vector3 randomDirection;  // Random movement direction

    void Start()
    {
        // Generate a random direction in 3D space
        randomDirection = Random.onUnitSphere; // Random direction on the surface of a sphere
        randomDirection.y = 0; // Optional: If you want to keep the movement on a flat plane, comment this out for full 3D movement
    }

    void Update()
    {
        // Move the asteroid in the random direction
        transform.Translate(randomDirection * speed * Time.deltaTime, Space.World);
    }
}

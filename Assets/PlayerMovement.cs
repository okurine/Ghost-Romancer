using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // how fast the player moves

    void Update()
    {
        // Get horizontal input: -1 (left arrow) to +1 (right arrow)
        float moveX = Input.GetAxisRaw("Horizontal");

        // Move the sprite on the x-axis
        transform.position += new Vector3(moveX, 0, 0) * speed * Time.deltaTime;
    }
}

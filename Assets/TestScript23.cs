using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript23 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // Move the sprite
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
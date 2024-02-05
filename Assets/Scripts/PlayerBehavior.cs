using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f; 

    void Update()
    {
        MoveRight();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void MoveRight(){
        // Calculate the movement vector
        Vector3 moveDirection = new Vector3(1f, 0f, 0f);

        // Move the object to the right
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    void Jump()
    {
        // Check if the object is grounded (you may need to implement a proper grounding check)
        // For simplicity, we are assuming the object is grounded here.

        // Apply upward force for the jump
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
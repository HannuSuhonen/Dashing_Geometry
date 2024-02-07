using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f; 

    private bool isJumping = false;

    Rigidbody2D RB;

    void Awake(){
        RB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //MoveRight();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    /* void MoveRight(){
        // Calculate the movement vector
        Vector3 moveDirection = new Vector3(1f, 0f, 0f);

        // Move the object to the right
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    } */

    void Jump()
    {
        if(isJumping == false){
            RB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
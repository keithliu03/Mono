using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;
    public float jumpForce;

    public bool isGrounded = false;

    void Start()
    {
        speed = 5;
        jumpForce = 7;
    }

    void Update()
    {
        Jump();
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            gameObject.GetComponent<ModeSwap>().toggleModes();
        }
    }
}

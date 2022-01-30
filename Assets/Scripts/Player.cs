using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float speed;
    public float jumpForce;
    public bool isGrounded = false;

    private Vector2 respawnPoint;

    void Start()
    {
        respawnPoint = GameObject.Find("RespawnPoint").transform.position;
        speed = 5;
        jumpForce = 7;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true) {
            Jump();
        }
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        animator.SetBool("Walk", (rb.velocity.x != 0));

        FlipInDirection(rb.velocity);

        if (gameObject.transform.position.y < -50)
        {
            Die();
        }
    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

        animator.SetTrigger("Jump");

        gameObject.GetComponent<ModeSwap>().toggleModes();
    }

    public void Die()
    {
        gameObject.transform.position = new Vector2(respawnPoint.x, respawnPoint.y);
    }

    void FlipInDirection(Vector2 direction)
    {
        if (direction.x < 0)
        {
            transform.localScale = new Vector2(-0.7f, 0.7f);
        }
        else if (direction.x > 0)
        {
            transform.localScale = new Vector2(0.7f, 0.7f);
        }
        
    }
}

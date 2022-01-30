using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject player;
    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "LightTiles" || collision.collider.tag == "DarkTiles")
        {
            player.GetComponent<Player>().isGrounded = true;
            animator.SetBool("Grounded", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "LightTiles" || collision.collider.tag == "DarkTiles")
        {
            player.GetComponent<Player>().isGrounded = false;
            animator.SetBool("Grounded", false);
        }
    }
}

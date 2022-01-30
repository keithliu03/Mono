using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject player;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        player.GetComponent<Player>().isGrounded = true;
        animator.SetBool("Grounded", true);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        player.GetComponent<Player>().isGrounded = false;
        animator.SetBool("Grounded", false);
    }
}

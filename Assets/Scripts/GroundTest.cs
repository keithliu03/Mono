using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTest : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;

    void Start()
    {
        rb = player.GetComponent<Player>().rb;
    }

    void Update()
    {
        if (Physics2D.OverlapBox(rb.position, new Vector2(1.5f, 0.5f), 0))
        {
            player.GetComponent<Player>().isGrounded = true;
        }
        else
        {
            player.GetComponent<Player>().isGrounded = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(new Vector2(rb.position.x + 1, rb.position.y + 1), new Vector2(0.25f, 1.5f));
        Gizmos.DrawWireCube(new Vector2(rb.position.x - 1, rb.position.y + 1), new Vector2(0.25f, 1.5f));
    }
}

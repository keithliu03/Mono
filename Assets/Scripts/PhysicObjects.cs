using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicObjects : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (player.GetComponent<ModeSwap>().getDarkModeOn() == false)
        {
            if (gameObject.tag == "DarkTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
            if (gameObject.tag == "LightTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }

        if (player.GetComponent<ModeSwap>().getDarkModeOn() == true) 
        {
            if (gameObject.tag == "DarkTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            }
            if (gameObject.tag == "LightTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            }
        }
    }
}

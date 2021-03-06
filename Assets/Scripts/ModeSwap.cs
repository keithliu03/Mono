using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwap : MonoBehaviour
{
    public GameObject player;

    private Renderer rend;
    private Collider2D colli;

    private GameObject[] lightMode;
    private GameObject[] darkMode;
    private bool darkModeOn;

    void Start()
    {
        lightMode = GameObject.FindGameObjectsWithTag("LightTiles");
        darkMode = GameObject.FindGameObjectsWithTag("DarkTiles");

        foreach (var tile in darkMode)
        {
            rend = tile.GetComponent<Renderer>();
            rend.enabled = false;

            colli = tile.GetComponent<Collider2D>();
            colli.enabled = false;
        }

        darkModeOn = false;
    }

    public void toggleModes()
    {
        if (darkModeOn == false)
        {
            foreach (var tile in darkMode)
            {
                rend = tile.GetComponent<Renderer>();
                rend.enabled = true;

                colli = tile.GetComponent<Collider2D>();
                colli.enabled = true;
            }

            foreach (var tile in lightMode)
            {
                rend = tile.GetComponent<Renderer>();
                rend.enabled = false;

                colli = tile.GetComponent<Collider2D>();
                colli.enabled = false;
            }

            darkModeOn = true;
            Camera.main.backgroundColor = Color.white;
            player.GetComponent<Renderer>().material.SetFloat("_Threshold", 0);
        }
        else
        {
            foreach (var tile in darkMode)
            {
                rend = tile.GetComponent<Renderer>();
                rend.enabled = false;

                colli = tile.GetComponent<Collider2D>();
                colli.enabled = false;
            }

            foreach (var tile in lightMode)
            {
                rend = tile.GetComponent<Renderer>();
                rend.enabled = true;

                colli = tile.GetComponent<Collider2D>();
                colli.enabled = true;
            }

            darkModeOn = false;
            Camera.main.backgroundColor = Color.black;
            player.GetComponent<Renderer>().material.SetFloat("_Threshold", 1);
        }
    }

    public bool getDarkModeOn()
    {
        return darkModeOn;
    }
}

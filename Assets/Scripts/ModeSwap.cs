using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwap : MonoBehaviour
{
    public Renderer rend;
    public Collider2D colli;

    private GameObject[] lightMode;
    private GameObject[] darkMode;
    private bool darkModeOn = false;

    // Start is called before the first frame update
    void Start()
    {
        lightMode = GameObject.FindGameObjectsWithTag("LightTiles");
        darkMode = GameObject.FindGameObjectsWithTag("DarkTiles");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            toggleModes();
        }
    }

    public void toggleModes()
    {
        Debug.Log(darkModeOn);
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
        }
    }
}

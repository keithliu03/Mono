using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwap : MonoBehaviour
{

    public GameObject[] lightMode;
    public GameObject[] darkMode;

    public Renderer rend;

    private bool lightModeOn = true;
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
            print("space key was pressed");
        }
    }

    public void toggleModes()
    {
        if (lightModeOn == true && darkModeOn == false)
        {
            foreach (var item in lightMode)
            {
                //item.GetComponent<Renderer>().disabled;
            }
            
        }
    }
}

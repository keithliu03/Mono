using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position = transform.position + new Vector3(-10 * Time.deltaTime, 0, 0); ;
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position = transform.position + new Vector3(10 * Time.deltaTime, 0, 0); ;
        }
    }
}

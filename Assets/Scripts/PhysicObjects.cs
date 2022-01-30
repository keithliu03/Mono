using UnityEngine;

public class PhysicObjects : MonoBehaviour
{
    public GameObject player;
    private RigidbodyConstraints2D originalConstraints;

    void Start()
    {
        originalConstraints = gameObject.GetComponent<Rigidbody2D>().constraints;
    }

    void Update()
    {
        if (player.GetComponent<ModeSwap>().getDarkModeOn() == false)
        {
            if (gameObject.tag == "DarkTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }

            if (gameObject.tag == "LightTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().constraints = originalConstraints;
            }
        }

        if (player.GetComponent<ModeSwap>().getDarkModeOn() == true) 
        {
            if (gameObject.tag == "DarkTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().constraints = originalConstraints;
            }

            if (gameObject.tag == "LightTiles")
            {
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            }
        }
    }
}

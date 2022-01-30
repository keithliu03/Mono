using UnityEngine;

public class PhysicObjects : MonoBehaviour
{
    public GameObject player;
    public Vector2 origPos;

    private RigidbodyConstraints2D originalConstraints;

    void Start()
    {
        origPos = transform.position;
        originalConstraints = gameObject.GetComponent<Rigidbody2D>().constraints;
    }

    void Update()
    {
        if ((Vector2)player.transform.position == player.GetComponent<Player>().getRespawnPoint())
        {
            ResetPhysicsObj();
        }

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

    public void ResetPhysicsObj()
    {
        transform.position = origPos;
    }
}

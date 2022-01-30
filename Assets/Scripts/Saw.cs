using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    float angle = 0;
    Vector3 startPos;
    public Vector2 travel;
    Vector2 dist;
    bool distXPassed = false, distYPassed = false;
    const int DIST_SPEED = 5;

    // Start is called before the first frame update
    void Start()
    {
        dist = new Vector2(0, 0);
        startPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        angle += Time.deltaTime * 250;
        if (angle >= 360)
            angle = 0;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        if (!distXPassed)
        {
            if (travel.x < 0)
                dist.x += -Time.deltaTime * DIST_SPEED;
            else if(travel.x != 0)
                dist.x += Time.deltaTime * DIST_SPEED;

            if ((travel.x < 0 && dist.x <= travel.x) || (travel.x > 0 && dist.x >= travel.x))
                distXPassed = !distXPassed;
        } else
        {
            if (travel.x < 0)
                dist.x += Time.deltaTime * DIST_SPEED;
            else if (travel.x != 0)
                dist.x += -Time.deltaTime * DIST_SPEED;

            if ((travel.x < 0 && dist.x >= 0) || (travel.x > 0 && dist.x <= 0))
                distXPassed = !distXPassed;
        }

        if (!distYPassed)
        {
            if (travel.y < 0)
                dist.y += -Time.deltaTime * DIST_SPEED;
            else if (travel.y != 0)
                dist.y += Time.deltaTime * DIST_SPEED;

            if ((travel.y < 0 && dist.y <= travel.y) || (travel.y > 0 && dist.y >= travel.y))
                distYPassed = !distYPassed;
        }
        else
        {
            if (travel.y < 0)
                dist.y += Time.deltaTime * DIST_SPEED;
            else if (travel.y != 0)
                dist.y += -Time.deltaTime * DIST_SPEED;

            if ((travel.y < 0 && dist.y >= 0) || (travel.y > 0 && dist.y <= 0))
                distYPassed = !distYPassed;
        }

        gameObject.transform.position = startPos +
            new Vector3(dist.x, dist.y, 0);
    }
}

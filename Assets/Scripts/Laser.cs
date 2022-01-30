using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    float speed = 0.5f;
    float curTime = 0;
    bool fadeOut = true;

    SpriteRenderer sRenderer;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        float ratio = curTime / speed;
        if (fadeOut)
            ratio = (1 - ratio);

        if(curTime >= speed)
        {
            curTime = 0;
            fadeOut = !fadeOut;
        }

        sRenderer.color = new Color(255, 255, 255, 0.25f + ratio * 0.75f);
    }
}

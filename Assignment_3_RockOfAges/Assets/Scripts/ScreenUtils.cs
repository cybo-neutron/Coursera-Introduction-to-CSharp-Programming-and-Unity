using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenUtils 
{
    public static float screenLeft, screenRight, screenTop, screenBottom;

    public static void Initialize()
    {
        float screenZ = -Camera.main.transform.position.z;
        Vector3 lowerLeftCorner = new Vector3(0, 0, screenZ);
        Vector3 topRightCorner = new Vector3(Screen.width, Screen.height, screenZ);
        lowerLeftCorner = Camera.main.ScreenToWorldPoint(lowerLeftCorner);
        topRightCorner = Camera.main.ScreenToWorldPoint(topRightCorner);
        screenLeft = lowerLeftCorner.x;
        screenRight = topRightCorner.x;
        screenBottom = lowerLeftCorner.y;
        screenTop = topRightCorner.y;


    }

}

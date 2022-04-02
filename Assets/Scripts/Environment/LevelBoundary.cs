using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -3.5f;// stating the boundaries 
    public static float rightSide = 3.5f;
    public float internalLeft;
    public float internalRight;

   

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide; // to see if the values are visible and working 
        internalRight = rightSide;
    }
}

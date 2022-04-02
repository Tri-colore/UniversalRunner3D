using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotateSpeed = 1;

    // Update is called once per frame
    void Update() // rotate the coin on the y axis
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}

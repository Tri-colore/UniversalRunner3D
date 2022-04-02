using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10;// how fast you want the player/object to move
    public float leftRightSpeed = 4; // determine how fast you can move left or right

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World); //makes sure that the player moves relative to the world around the player


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // getting the key input from the keyboard
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {// this refers to whatever the script is attached to, This if is to check if the player goes beyond the left side of the boundary
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }// delta time to make sure it is working in the same time space
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {// getting the key input from the keyboard

            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);// the negative One is there to negate or invert the number  so if going left at 2, press the other key and it it will move at -2
            }

            // if statement is basically to allow the player to move if they are not at the boundarya
            // and restrict movement if they are

        }
    }
}

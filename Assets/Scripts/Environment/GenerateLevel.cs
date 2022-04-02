using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50; // first place we generate a section
    public bool creatingSection = false;
    public int secNum;// section number

   

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true; // to make sure we dont run this co routine over and over again
            StartCoroutine(GenerateSection()); //coroutine is a like a method in which time delay can be added
        }
        
    }
    IEnumerator GenerateSection() // this is infinetly generating a level
    {
        secNum = UnityEngine.Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(2);// creating a section every  2 seconds
        creatingSection = false;
    }
}

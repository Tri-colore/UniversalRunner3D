using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun; //distance rrun
    public bool addingDis = false;
        public float disDelay = 0.35f;
   
    // Update is called once per frame
    void Update()
    {
        if (addingDis == false) // if we are not already adding distance then we add a meter every interval
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }
    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}

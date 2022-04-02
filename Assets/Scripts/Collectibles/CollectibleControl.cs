using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollectibleControl : MonoBehaviour
{
    public static int coinCount;

    public GameObject coinCountDisplay;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount; // getting the component from the UI
    }
}

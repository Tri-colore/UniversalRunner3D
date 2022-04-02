using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFx;

     void OnTriggerEnter(Collider other)// play collect sound when collided with  player and disable after
    {

        coinFx.Play();
        CollectibleControl.coinCount += 1; // updates the UI coin counter
        this.gameObject.SetActive(false);
    }
}


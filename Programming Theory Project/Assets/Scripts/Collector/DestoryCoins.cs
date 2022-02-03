using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCoins : MonoBehaviour
{
    //Attach to Coins, Chest and Heart.
    //ABSTRACTION
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

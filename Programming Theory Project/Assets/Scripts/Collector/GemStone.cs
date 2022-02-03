using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class GemStone : Collector
{
    public GameObject starIndicator;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DestoryObject();
            starIndicator.gameObject.SetActive(true);
        }
    }
}

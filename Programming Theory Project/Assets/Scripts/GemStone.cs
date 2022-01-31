using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class GemStone : Collector
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Gemstone();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject objToDestory;
    public GameObject gemStone;
  
    public void Gemstone()
    {
        gemStone.gameObject.SetActive(true);
        Destroy(objToDestory);
    }
}

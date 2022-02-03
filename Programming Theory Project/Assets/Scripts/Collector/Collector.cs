using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public ParticleSystem particle;
    //ABSTRACTION
    public void DestoryObject()
    {
        Destroy(gameObject);
        Instantiate(particle, transform.position, particle.transform.rotation);
    }
}

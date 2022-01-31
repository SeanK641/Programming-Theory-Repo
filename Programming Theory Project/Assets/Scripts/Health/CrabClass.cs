using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CrabClass : EnemyClass
{
    //POLYMORPHISM
    public GameObject gameOverText;
    public override void HealthMeter() // can override virtual methods from parent class
    {
        gameOverText.gameObject.SetActive(true);
        Life = 0;
        HealthText.text = "Health : " + Life;
    }

    //Keep Public
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            HealthMeter();
        }
    }
}

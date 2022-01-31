using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyClass : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int Life;

    // Start is called before the first frame update
    void Start()
    {
        Life = 50;
    }

    public virtual void HealthMeter() 
    {
        Life -= 10;
        HealthText.text = "Health : " + Life;
    }

    //Keep Private
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HealthMeter();
        }
    }
}

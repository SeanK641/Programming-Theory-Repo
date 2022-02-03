using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class CrabClass : EnemyClass
{
    private Animator playerAnim;
    //Can call Scripts using Object. 
    private Object playerController;

    //POLYMORPHISM
    public override void HealthMeter() // can override virtual methods from parent class
    {
        //Enemy Class essentials, that do not carry over.
        Access();
        Destroy(playerController);

        life = 0;
        gameOver = true;
        gameOverText.gameObject.SetActive(true);
        playerAnim.SetBool("Death", true);
        HealthText.text = "Health : " + life;
    }

    //Needed to access Animator and Player Controller
    public void Access()
    {
        //Calls animator component from the Bee
        playerAnim = GameObject.Find("Bee").GetComponent<Animator>();
        //Destories the Player Controller Script, Preventing the Player from Movement
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

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

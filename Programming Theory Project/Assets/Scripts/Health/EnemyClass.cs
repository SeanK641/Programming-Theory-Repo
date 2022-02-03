using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyClass : MonoBehaviour
{
    public int life;
    public TextMeshProUGUI HealthText;
    public GameObject gameOverText;
    public bool gameOver = false;

    private Animator playerAnim;
    //Can call Scripts using Object. 
    private Object playerController; 

    // Start is called before the first frame update
    void Start()
    {
        life = 50;

        //Calls animator component from the Bee
        playerAnim = GameObject.Find("Bee").GetComponent<Animator>();
        //Destories the Player Controller Script, Preventing the Player from Movement
        playerController = GetComponent<PlayerController>();
    }

    public virtual void HealthMeter() 
    {
        life -= 10;
        HealthText.text = "Health : " + life;

        if (life < 10)
        {
            playerAnim.SetBool("Death", true);
            GameOver();
            Destroy(playerController);
        }
    }

    //Keep Private
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            HealthMeter();
        }

        if (other.gameObject.CompareTag("Heart"))
        {
            life += 10;
            HealthText.text = "Health : " + life;
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        gameOver = true;
    }
}

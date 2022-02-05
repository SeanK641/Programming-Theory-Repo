using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndLevel : MonoBehaviour
{
    //Can call Scripts using Object. 
    private Object playerController;

    public GameObject wellDoneText;

    // Start is called before the first frame update
    void Start()
    {
        //Destories the Player Controller Script, Preventing the Player from Movement
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(playerController);
            wellDoneText.gameObject.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCollection : Collector
{
    public TextMeshProUGUI CoinText;
    public int Coins;

    // Start is called before the first frame update
    void Start()
    {
        Coins = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        //INHERITANCE
        if (other.gameObject.CompareTag("Coin"))
        {
            Coins += 1;
            CoinText.text = "Coins : " + Coins;
        }

        if (other.gameObject.CompareTag("Chest"))
        {
            Coins += 10;
            CoinText.text = "Coins : " + Coins;
        }

        if (other.gameObject.CompareTag("GemStone"))
        {
            Coins += 100;
            CoinText.text = "Coins : " + Coins;
        }
    }
}

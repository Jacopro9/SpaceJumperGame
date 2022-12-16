using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayValue : MonoBehaviour
{
    
    public int Value = 10;
    public Text ValueText;

    void Update()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerHP playerHP = Player.GetComponent<PlayerHP>();
        ValueText.text = "HP: " + playerHP.health.ToString();


    }

}

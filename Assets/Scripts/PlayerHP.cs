using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int health = 100;
    public string textValue;
    
    

    public void TakeDamage (int damage)

    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
        }
    }

    
    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    public float increase = 5f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            PlayerMovement PlayerMovement = player.GetComponent<PlayerMovement>();
            if (PlayerMovement)
            {
                PlayerMovement.jumpForce += increase;
                Destroy(gameObject);
                FindObjectOfType<AudioManager>().Play("PowerupPickup");
            }
        }
    }

}

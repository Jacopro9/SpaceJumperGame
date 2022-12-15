
using UnityEngine;

public class SpeedPowerup : MonoBehaviour
{


    public float increase = 3f;

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject player = collision.gameObject;
            PlayerMovement PlayerMovement = player.GetComponent<PlayerMovement>();
             if(PlayerMovement)
            {
                PlayerMovement.moveSpeed += increase;
                Destroy(gameObject);
            }
        }
    }

    void Pickup()
    {
        Debug.Log("Speed powerup picked up"); 
    }
}

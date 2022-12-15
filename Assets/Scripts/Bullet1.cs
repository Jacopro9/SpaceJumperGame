using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    [SerializeField] private GameObject bulletImpact1Prefab;

    public float speed = 10f;

    public int damage = 35;

    PlayerMovement target;
    Vector2 moveDirection;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerMovement>();
        moveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (!hitInfo.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Instantiate(bulletImpact1Prefab, transform.position, transform.rotation);
        }

    }
}
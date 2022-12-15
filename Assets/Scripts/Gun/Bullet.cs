using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletImpactPrefab;

    public float speed = 10f;

    public int damage = 35;

    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
        Object.Destroy(gameObject, 2.0f);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (!hitInfo.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(bulletImpactPrefab, transform.position, transform.rotation);
        }
    }
}

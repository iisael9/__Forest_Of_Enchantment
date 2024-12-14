using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    public int damageAmount = 20; // Adjust the damage amount as needed

    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");

        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(gameObject, 150);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collided with the player
        if (other.CompareTag("Player"))
        {
            // Get the Damageable script of the player
            Damageable playerDamageable = other.GetComponent<Damageable>();

            // Check if the Damageable script is not null
            if (playerDamageable != null)
            {
                // Apply damage to the player
                playerDamageable.Hit(damageAmount, bulletRB.velocity.normalized);
            }

            // Destroy the bullet when it hits the player
            Destroy(gameObject);
        }
    }
}

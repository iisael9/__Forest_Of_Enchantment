using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject fireball;
    public Transform firePos;
    private float timer;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        if(distance < 25)
        {
            timer += Time.deltaTime;

            if (timer > 1.5)
            {
                timer = 0;
                shoot();
            }
        }
        
    }

    void shoot()
    {
        Instantiate(fireball, firePos.position, Quaternion.identity);
    }
}

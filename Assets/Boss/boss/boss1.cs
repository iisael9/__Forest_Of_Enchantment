using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    private Transform player;
    public float lineOfSite;
    public float shootingRange;
    public float fireRate = 1f;
    private float nextFireTime;
    public GameObject bullet;
    public GameObject bulletParent;

    private Animator animator;

    

    void Start()
    {
        

        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if(distanceFromPlayer <  lineOfSite && distanceFromPlayer>shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);


            //flip sprite to face the player
            if (player.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }

            else 
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }

            animator.SetBool("IsAttacking", false);


        }

        else if (distanceFromPlayer<= shootingRange && nextFireTime <Time.time)
        {


            animator.SetBool("IsAttacking", true);

            if (player.position.x < transform.position.x)
             {
                // Player is on the left side
                transform.localScale = new Vector3(1, 1, 1);
             }
            else
            {
                // Player is on the right side
                transform.localScale = new Vector3(-1, 1, 1);
            }


            Instantiate(bullet,bulletParent.transform.position,Quaternion.identity);
            nextFireTime = Time.time + fireRate;

            
        }

        else 
        {
            animator.SetBool("IsAttacking", false);
        }


         
   

    }


    //public below might not be needed
    public void OnHit(int damage, Vector2 knockback)
    {
        rb.velocity = new Vector2(knockback.x, rb.velocity.y + knockback.y);
    }
    
    //code bellow is a visual to see the range in game
    
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
    

    

   
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batFollow : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    private Transform player;
    public float lineOfSite;
    public float shootingRange;
    public DetectionZone attackZone;

    Animator animator;
    
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;    
    }


    //can delete bellow if not needed
    public bool _hasTarget = false;
    public bool HasTarget { 
        get { return _hasTarget; } 
        private set
        { 
            _hasTarget = value;
            animator.SetBool(AnimationStrings.hasTarget, value);
        
        } }


        //can delete float below if not needed
     public float AttackCooldown { get 
        {
            return animator.GetFloat(AnimationStrings.attackCooldown);
        
        } private set
        {
            animator.SetFloat(AnimationStrings.attackCooldown, Mathf.Max(value, 0));
        }
    }


    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if(distanceFromPlayer <  lineOfSite)
        transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);

        //can delete bellow if not work
        HasTarget = attackZone.detectedColliders.Count > 0;
        if (AttackCooldown > 0)
        {
            AttackCooldown -= Time.deltaTime;

        }
    }

    public void OnHit(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Damageable>().Health -= 50;
            Destroy(gameObject);
        }
    }
    

    
    //code bellow is a visual to see the range in game
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }

    
    
}

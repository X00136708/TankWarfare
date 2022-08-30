
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Ground;

class PlayerDefaultShot : Bullet
{
    public override float speed { get; set; } = 10;
    public override int damage { get; set; }  = 100;
    public override string type { get; set; } = "DefaultShot";
    public Vector3 respawnPoint;
    public Rigidbody2D rb;
    public bool stillMoving = true;


    void Start()
    {
       
    }
  
    void Update()
    {
        Shot();       
    }
    public override void Shot()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.gravityScale = 1;
            respawnPoint = GameObject.Find("Firepoint_player").transform.position;
            rb.velocity = transform.right * this.speed;            
        }
    }
    public override void Hit(Collision2D collision)
    {
        stillMoving = true;
        while (stillMoving)
        {
            if (rb.angularVelocity == 0)
            {
                rb.transform.position = respawnPoint;
                rb.gravityScale = 0;
                stillMoving = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {      
        Hit(collision);
    }
}


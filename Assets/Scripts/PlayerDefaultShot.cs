
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Ground;

class PlayerDefaultShot : Bullet
{

    public override bool isInMotion { get; set; }
    public override float speed { get; set; } = 10;
    public override int damage { get; set; } = 100;
    public override string type { get; set; } = "DefaultShot";
    public Vector3 respawnPoint;
    public float initRotation;
    public Rigidbody2D rb;    

    public PlayerDefaultShot()
    {
        isInMotion = true;
    }
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Init(); 
            if(!isInMotion)
            Shot();
        }
    }
    //Initialize the ball with these properties
    public void Init()
    {
        //Bullet is transparent by default (so that the use can't see it until it is shot). This line sets the transparency of the bullet to 0, so it can be seen
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
        //Initialize gravity so bullet can simulate falling. Doing this in unity will make it fall immidietely when game is loaded
        rb.gravityScale = 1;
        //get the point of the Firepoint_player tag, so we can reset the bullet to there later
        respawnPoint = GameObject.Find("Firepoint_player").transform.position;
        initRotation = rb.rotation;
    }
    public override void Shot()
    {               
        //Move the bullet when shot
        rb.velocity = transform.right * this.speed;
        isInMotion = true;        
    }
    //First method to be called when this object is hit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Call our own Hit method to do it's own thing. Not needed, but just sounds better. 
        Hit(collision);
    }
    public override void Hit(Collision2D collision)
    {
        //do something with the collision that happened. Did it collide with ground or with another tank?

        //Reset the bullet back to the front of the tank, to be shot again
        ResetShot();        
    }
    public void ResetShot()
    {
        //Make bullet Transparent again, so it's not seen on the front of the tank
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        //Stop the bullet from moving when it's reset to the front of the tank
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0;
        rb.inertia = 0;
        rb.rotation = initRotation;
        //Stop the bullet from falling when it's reset
        rb.gravityScale = 0;
        //Spawn the bullet back on the front of the tank when reset
        rb.transform.position = respawnPoint;
        isInMotion = false;
    }
    
}


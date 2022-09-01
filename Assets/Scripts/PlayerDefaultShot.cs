
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Ground;

class PlayerDefaultShot : Bullet
{

    public override bool isInMotion { get; set; }
    public override float power { get; set; } = 30;    
    public override int damage { get; set; } = 100;
    public override string type { get; set; } = "DefaultShot";
    public override float angularVelocity { get; set; }
    public override Vector2 velocity { get; set; }
    public override float initRotation{ get; set; }

    public Vector3 respawnPoint;  
    public Rigidbody2D rb;
    

    public float Power {get {return power;} set {power = value;}}
    public int Damage {get {return damage;} set {damage = value;}}
    public string Type {get {return type;} set {type = value;}}
    public float AngularVelocity { get {return angularVelocity;} set { angularVelocity = value;}}
    public Vector2 Velocity { get {return velocity;} set { velocity = value;}}
    public float InitRotation { get {return initRotation;} set { initRotation = value;}}
   

    void Start()
    {        
        Init();
    }

    void Update()
    {                                        
    }
    //Initialize the ball with these properties
    public void Init()
    {
        //Bullet is transparent by default (so that the use can't see it until it is shot). This line sets the transparency of the bullet to 0, so it can be seen                      
        //get the point of the Firepoint_player tag, so we can reset the bullet to there later                
        

    }
    public override void Shot()
    {
        
       //Move the bullet when shot                
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
        respawnPoint = GameObject.Find("Firepoint_player").transform.position;
        //Make bullet Transparent again, so it's not seen on the front of the tank
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);       
        //Stop the bullet from falling when it's reset
        rb.gravityScale = 0;
        //Spawn the bullet back on the front of the tank when reset
        rb.transform.position = respawnPoint;        
        rb.velocity = Vector3.zero;
        rb.angularVelocity = 0;
        rb.rotation = initRotation;
        isInMotion = false;        
    }
    public override void SetRBSettings(Bullet b)
    {
        rb.velocity = b.velocity;        
    }
}


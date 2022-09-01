using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public abstract class Bullet : MonoBehaviour
    {  
    public abstract bool isInMotion { get; set; }
    public abstract float power { get; set; }
    public abstract int damage { get; set; }
    public abstract string type { get; set; }          
    public abstract float angularVelocity { get; set; }          
    public abstract Vector2 velocity{ get; set; }          
    public abstract float initRotation{ get; set; }    
    public Rigidbody2D rb;   
    public abstract void Hit(Collision2D collision);
    public abstract void SetRBSettings(Bullet b);

    }


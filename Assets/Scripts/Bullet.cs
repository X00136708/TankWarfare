using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public abstract class Bullet : MonoBehaviour
    {
    public float speed;
    public int damage;
    public string type;    

    protected Bullet(float speed, int damage, string type)
    {
        this.speed = speed;
        this.damage = damage;
        this.type = type;
    }

    public string Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
    }        
        public abstract void Shot();
        public abstract void Hit();

    }


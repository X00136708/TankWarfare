using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public abstract class Bullet : MonoBehaviour
    {
    public abstract float speed { get; set; }
    public abstract int damage { get; set; }
    public abstract string type { get; set; }          
    public abstract void Shot();
    public abstract void Hit(Collision2D collision);
    }


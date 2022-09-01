using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tank : MonoBehaviour
{
    public abstract Health tankHealth { get; set; }
    public abstract void Move();    
    public abstract void Shoot();
    public abstract void TakeDamage(int damage);
    public abstract void Die();

}

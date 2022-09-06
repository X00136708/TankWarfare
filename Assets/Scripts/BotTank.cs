using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class BotTank : Tank
{
    GameObject currentObj;    
    PlayerTankBarrel tankBarrel;
    Health health;

    private void Start()
    {
        maxHealth = 40;
        currentObj = GameObject.Find("Bullet");
        bullet = currentObj.GetComponent<Bullet>();
        currentObj = GameObject.Find("TankBarrelLeft");
        tankBarrel = currentObj.GetComponent<PlayerTankBarrel>();
        currentObj = GameObject.Find("HealthBar");
        //healthBar = currentObj.GetComponent<HealthBar>();
        CurrentHealth = maxHealth;
        currentObj = GameObject.Find("Health");
    }
    public override void Die()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }

    public override void Shoot()
    {
        throw new NotImplementedException();
    }
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag.Equals("Bullet"))
        {
            TakeDamage(this.gameObject, bullet.damage);            
            
        }
    }
}


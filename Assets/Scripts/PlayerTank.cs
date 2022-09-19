using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Path;
using UnityEngine;

public class PlayerTank : Tank
{
    GameObject currentObj;    
    PlayerTankBarrel tankBarrel;    

    private void Start()
    {       
        maxHealth = 100;
        currentObj = GameObject.Find("Bullet");
        bullet = currentObj.GetComponent<Bullet>();
        currentObj = GameObject.Find("TankBarrelLeft");
        tankBarrel = currentObj.GetComponent<PlayerTankBarrel>();
        currentObj = GameObject.Find("HealthBar");        
        CurrentHealth = maxHealth;        
    }

    void Update()
    {
        if(bullet != null)
            //bullet.rb.rotation = tankBarrel.transform.localEulerAngles.z;
        Move();
        if (Input.GetKey(KeyCode.Space))
        {
            if (!bullet.isInMotion)
                Shoot();
        }
    }
    public override void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if(!bullet.isInMotion)
                this.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (!bullet.isInMotion)
                this.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
    
    public override void Shoot()
    {      
        bullet.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
        bullet.initRotation = tankBarrel.transform.localEulerAngles.z;
        bullet.rb.gravityScale = 1;       
        bullet.velocity = bullet.transform.right * (bullet.power * tankBarrel.tankBarrelEulerAxisX);
        bullet.SetRBSettings(bullet);
        bullet.isInMotion = true;        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider == GameObject.Find("Bullet"))
        {
            TakeDamage(this.gameObject, bullet.damage);
            healthBar.setHealth(30);            
        }
    }    
    public override void Die()
    {         
        Destroy(gameObject);
    }
    }


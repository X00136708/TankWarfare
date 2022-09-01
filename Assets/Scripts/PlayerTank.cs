using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{
    GameObject bulletObj;
    Bullet bullet;
    GameObject tankBarrelObj;
    PlayerTankBarrel tankBarrel;
    private void Start()
    {
        bulletObj = GameObject.Find("Bullet");
        bullet = bulletObj.GetComponent<Bullet>();
        tankBarrelObj = GameObject.Find("TankBarrelLeft");
        tankBarrel = tankBarrelObj.GetComponent<PlayerTankBarrel>();
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
        bullet.velocity = bullet.transform.right * bullet.power;
        bullet.SetRBSettings(bullet);
        bullet.isInMotion = true;
    }
    public override void TakeDamage(int damage)
    {//this is how the player takes damage
        //CurrentHealth -= damage;
        ////this links the players health to the health bar.
        //healthBar.setHealth(CurrentHealth);
        //if (CurrentHealth <= 0)
        //{//checks if the players health is 0, if true then it kills the player.
        //    Die();
        //}
    }
    public override void Die()
    {         
        Destroy(gameObject);
    }
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{
    GameObject bulletObj;
    PlayerDefaultShot bullet;
    private void Start()
    {
        bulletObj = GameObject.Find("Bullet");
        bullet = bulletObj.GetComponent<PlayerDefaultShot>();
    }
    void Update()
    {        
        Move();       
        Shoot();
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
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    this.GetComponent()
        //}
    }
}

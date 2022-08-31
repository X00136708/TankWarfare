using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{
    // Update is called once per frame
    void Update()
    {        
        Move();       
        Shoot();
    }
    public override void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {            
                this.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {           
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

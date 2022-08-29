using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{            
    // Update is called once per frame
    void Update()
    {
        Move();
        RotateBarrel();
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
    public override void RotateBarrel()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, 0, Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0, 0, Time.deltaTime);
        }
    }
    public override void ExtendBarrel()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, 0, Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(0, 0, Time.deltaTime);
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

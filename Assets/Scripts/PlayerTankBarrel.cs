using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    class PlayerTankBarrel : TankBarrel
    {
    void Start()
    {
        
    }
    void Update()
    {
        RotateBarrel();
        ExtendBarrel();
    }
    public override void RotateBarrel()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, 0, Time.deltaTime*5);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 0, Time.deltaTime*-5);
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
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    class PlayerTankBarrel : TankBarrel
    {
    GameObject bulletObj;
    Bullet bullet; 
    GameObject tankBarrelExtendedObj;
    //TankBarrelExtended tankBarrelExtended;    
    void Start()
    {
        bulletObj = GameObject.Find("Bullet");
        bullet = bulletObj.GetComponent<Bullet>();
        tankBarrelExtendedObj = GameObject.Find("TankBarrelExtendedLeft");
//        tankBarrelExtended = tankBarrelExtendedObj.GetComponent<TankBarrelExtended>();
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
            if (!bullet.isInMotion)
                this.transform.Rotate(0, 0, Time.deltaTime*50);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!bullet.isInMotion)
                this.transform.Rotate(0, 0, Time.deltaTime*-50);
        }
    }
    public override void ExtendBarrel()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tankBarrelExtendedObj.transform.Translate(new Vector3(1.204f, 0.131f, -0.0065f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tankBarrelExtendedObj.transform.Translate(new Vector3(-0.901f, -0.099f, -0.0065f) * Time.deltaTime);
        }
    }
}


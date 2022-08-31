using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    class PlayerTankBarrel : TankBarrel
    {
    GameObject bulletObj;
    PlayerDefaultShot bullet;
    void Start()
    {
        bulletObj = GameObject.Find("Bullet");
        bullet = bulletObj.GetComponent<PlayerDefaultShot>();
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


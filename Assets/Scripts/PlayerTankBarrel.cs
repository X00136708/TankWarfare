using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    class PlayerTankBarrel : TankBarrel
    {
    GameObject bulletObj;
    Bullet bullet; 
    GameObject tankBarrelExtendedObj;
    Vector3 extendedPosition;
    Vector3 retractedPosition;  
    

    //TankBarrelExtended tankBarrelExtended;    
    void Start()
    {
        tankBarrelEulerAxisX = 1;
        bulletObj = GameObject.Find("Bullet");
        bullet = bulletObj.GetComponent<Bullet>();
        tankBarrelExtendedObj = GameObject.Find("TankBarrelExtendedLeft");
        extendedPosition = tankBarrelExtendedObj.transform.localPosition;
        retractedPosition = new Vector3(.7f, .08f, 0f);
      
    }    
    void Update()
    {
        if (!bullet.isInMotion)
        {
            RotateBarrel();
            ExtendBarrel();
        }
    }
    public override void RotateBarrel()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {     
            this.transform.Rotate(0, 0, Time.deltaTime*50);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {           
            this.transform.Rotate(0, 0, Time.deltaTime*-50);
        }
    }
    public override void ExtendBarrel()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (!(Vector3.Distance(tankBarrelExtendedObj.transform.localPosition, extendedPosition) < 0.05f))
            {
                tankBarrelExtendedObj.transform.Translate(new Vector3(1.218015f, 0.1071854f, 0f) * Time.deltaTime * .5f);
                this.tankBarrelEulerAxisX = tankBarrelExtendedObj.transform.localPosition.x;
            }
            else
            {
                
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (!(Vector3.Distance(tankBarrelExtendedObj.transform.localPosition, retractedPosition) < 0.1f))
            {
                tankBarrelExtendedObj.transform.Translate(new Vector3(-1.218015f, -0.1071854f, 0f) * Time.deltaTime * .5f);
                this.tankBarrelEulerAxisX = tankBarrelExtendedObj.transform.localPosition.x;
            }
            else
            {
                
            }
        }
    }
}


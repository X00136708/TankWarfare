using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

class BotTank : Tank
{
    GameObject currentObj;
    BotTankBarrel tankBarrel;
    HealthBar Bar;//this is a change i made    
    Vector3 directionTime;
    float Sec;    

    private void Start()//not sure why this broke or how to fix it 
    {
        maxHealth = 100;
        currentObj = GameObject.Find("Bullet");
        bullet = currentObj.GetComponent<Bullet>();
        currentObj = GameObject.Find("TankBarrelRight");
        tankBarrel = currentObj.GetComponent<BotTankBarrel>();
        currentObj = GameObject.Find("HealthBar");
        CurrentHealth = maxHealth;
        //Bar.setMaxHealth(maxHealth);//this is a change i made
        currentObj = GameObject.Find("Health");        
    }
    private void Update()
    {
        if (botsTurnMove)
        {            
            if (Sec <= 3)
            {
                Sec += 1 * Time.deltaTime;
                Move();
            }
            else
            {
                Sec = 0;
                botsTurnMove = false;
                botsTurnShoot = true;                
            }

        }
        if (botsTurnShoot)
        {
            tankBarrel.RotateBarrel();            
            botsTurnMove = false;
            botsTurnShoot = false;
        }

    }

    public override void Die()
    {

    }

    public override void Move()
    {
        {

            if (!bullet.isInMotion)
            {
                directionTime = (GenerateRandomLeftorRightDirection() == 1) ? (Vector3.left * Time.deltaTime) : (Vector3.right * Time.deltaTime);
                this.transform.Translate(directionTime);
            }

        }
    }

    public override void Shoot()
    {
        throw new NotImplementedException();
    }


}


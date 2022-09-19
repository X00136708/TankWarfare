using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using Random = System.Random;

class BotTank : Tank
{
    GameObject currentObj;    
    PlayerTankBarrel tankBarrel;    
    HealthBar Bar;//this is a change i made
    Random rand;
    Vector3 directionTime;
    int randNumber;
    float Sec;

    private void Start()//not sure why this broke or how to fix it 
    {
        maxHealth = 100;
        currentObj = GameObject.Find("Bullet");
        bullet = currentObj.GetComponent<Bullet>();
        currentObj = GameObject.Find("TankBarrelLeft");
        tankBarrel = currentObj.GetComponent<PlayerTankBarrel>();
        currentObj = GameObject.Find("HealthBar");        
        CurrentHealth = maxHealth;
        Bar.setMaxHealth(maxHealth);//this is a change i made
        currentObj = GameObject.Find("Health");
        rand = new Random();
        randNumber = rand.Next(1, 2);

    }
    private void Update()
    {
        if (botsTurn)
        {
            if (Sec <= 3)
            { Sec += 1 * Time.deltaTime; print(Sec);
                Move();
            }
            
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
                directionTime = (randNumber == 1) ? (Vector3.left * Time.deltaTime) : (Vector3.right * Time.deltaTime);
                this.transform.Translate(directionTime);
            }
           
        }      
    }

    public override void Shoot()
    {
        throw new NotImplementedException();
    }
   
    
}


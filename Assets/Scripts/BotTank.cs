using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

class BotTank : Tank
{
    GameObject currentObj;
    BotTankBarrel tankBarrel;
    HealthBar Bar;//this is a change i made
    int localRandPerTurn;

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

    }
    public override void NewTurn()
    {        
        localRandPerTurn = GenerateRandomLeftorRightDirection();
        Move();
        botsTurnMove = false;
        botsTurnShoot = true;


        if (botsTurnShoot)
        {
            tankBarrel.RotateBarrel();
            botsTurnMove = false;
            botsTurnShoot = false;
        }

    }
    public override void Move()
    {
        StartCoroutine(MoveOverSeconds(gameObject, new Vector3(0.0f, 0f, 0f), 3f));
    }

    public IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 end, float seconds)
    {        
        float elapsedTime = 0;
        Vector3 startingPos = this.transform.position;
        while (elapsedTime < seconds)
        {
            this.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        this.transform.position = end;
    }


    public override void Die()
    {

    }    

    public override void Shoot()
    {
        throw new NotImplementedException();
    }


}


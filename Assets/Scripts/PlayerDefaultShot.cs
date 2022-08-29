
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class PlayerDefaultShot : Bullet
{
    Bullet bullet = new PlayerDefaultShot(20f, 100, "DefaultShot");
    public PlayerDefaultShot(float speed, int damage, string type) : base(speed, damage, type)
    {
        bullet.speed = speed;
        bullet.damage = damage;
        bullet.type = type;
    }
    public override void Shot()
    {

    }
    public override void Hit()
    {
        
    }    
}


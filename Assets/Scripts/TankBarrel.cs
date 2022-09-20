using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TankBarrel : GenericMethods
{
    public abstract void RotateBarrel();
    public abstract void ExtendBarrel();

    public float tankBarrelEulerAxisX;
    
}

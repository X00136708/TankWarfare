using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TankBarrel : MonoBehaviour
{
    protected abstract void RotateBarrel();
    protected abstract void ExtendBarrel();

    public float tankBarrelEulerAxisX;
    
}

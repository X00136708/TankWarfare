using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TankBarrel : MonoBehaviour
{    
    // Start is called before the first frame update   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public abstract void RotateBarrel();   
    public abstract void ExtendBarrel();
}

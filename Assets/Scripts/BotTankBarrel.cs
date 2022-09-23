using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class BotTankBarrel : TankBarrel
    {    
    float barrelDirection;
    private void Start()
    {        
    }
    public override void ExtendBarrel()
        {         
        
        }

        public override void RotateBarrel()
        {            
            barrelDirection = (GenerateRandomLeftorRightDirection() == 1) ? (5000) : (-5000);
            this.transform.Rotate(0, 0, Time.deltaTime * barrelDirection);
        }
    }

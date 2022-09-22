﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

public class BotTankBarrel : TankBarrel
    {
        Random rand;
        float barrelDirection;
    private void Start()
    {
        rand = new Random();
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
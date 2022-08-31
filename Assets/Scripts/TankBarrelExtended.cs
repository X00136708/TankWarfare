using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class TankBarrelExtended : MonoBehaviour
    {
        GameObject tankBarrelObj;
        PlayerTankBarrel tankBarrel;
        void Start()
        {
            tankBarrelObj = GameObject.Find("TankBarrelLeft");
            tankBarrel = tankBarrelObj.GetComponent<PlayerTankBarrel>();
        }
        void Update()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {                             
                this.transform.Translate(new Vector3(1.204f, 0.131f, - 0.0065f) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(new Vector3(-0.901f, -0.099f, -0.0065f) * Time.deltaTime);               
            }

        }
    }    
}

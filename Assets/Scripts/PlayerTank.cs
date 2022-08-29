using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTank : Tank
{
    // Start is called before the first frame update
    Tank playerTank = new PlayerTank();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public override void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}

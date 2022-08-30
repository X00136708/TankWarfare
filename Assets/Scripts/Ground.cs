using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Ground
{
    class Ground : MonoBehaviour
    {
        public Rigidbody2D rb;
        public Collision2D Collider { get; set; }
        public void OnCollisionEnter2D(Collision2D collision)
        {
            this.Collider = collision;
        }
    }
}

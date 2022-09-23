using System.Collections;
using UnityEngine;
using Random = System.Random;
    public class GenericMethods : MonoBehaviour
{
        public Random rand = new Random();
        private int randNumber;
        public int GenerateRandomLeftorRightDirection()
        {            
            return randNumber = rand.Next(1, 2);
        }
}

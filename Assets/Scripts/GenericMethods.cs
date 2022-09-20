using System.Collections;
using UnityEngine;
using Random = System.Random;
    public class GenericMethods : MonoBehaviour
{
        private Random rand;
        private int randNumber;
        public int GenerateRandomLeftorRightDirection()
        {
            rand = new Random();
            return randNumber = rand.Next(1, 2);
        }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
    public class FishCollision : MonoBehaviour
    {
        public FlockManager myManager;


        private void OnTriggerEnter(Collider collision)
        {
            if (collision.tag == "FishFood")
            {
                collision.gameObject.GetComponent<Food>().FoodBiteDecrease();
            }
        }
    }
}

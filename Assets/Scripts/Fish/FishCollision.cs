using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tojam2022
{
    public class FishCollision : MonoBehaviour
    {
        public FlockManager myManager;
        public Fish fish;


        private void OnTriggerEnter(Collider collision)
        {
            if (collision.tag == "FishFood")
            {
                Debug.LogWarning("Eat food");
                collision.gameObject.GetComponent<Food>().FoodBiteDecrease();
                fish._Food += 10;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    public FlockManager myManager;


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "FishFood")
        {
            collision.gameObject.GetComponent<Food>().FoodBiteDecrease();
        }
    }
}

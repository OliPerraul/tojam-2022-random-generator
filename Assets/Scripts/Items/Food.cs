using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] Rigidbody rb;

    [SerializeField] Vector3 _destination;
    public Vector3 _Destination
    {
        get { return _destination; }
        set { _destination = value; }
    }


    [SerializeField] int numberOfBites;

    [SerializeField] FishFoodContainer _fishFoodContainer;
    public FishFoodContainer _FishFoodContainer
    {
        get { return _fishFoodContainer; }
        set { _fishFoodContainer = value; }
    }

    [SerializeField] float dropSpeed =1 ; 

    private void FixedUpdate()
    {
        
    }

    public void FoodBiteDecrease()
    {
        if(numberOfBites > 1)
        {
            numberOfBites--;
        }
        else
        {
            _fishFoodContainer.UpdateFishFoodList(this);
        }
        
    }

    public void DropFoodAtDestination(Vector3 startPosition, Vector3 dest)
    {

        transform.position = startPosition;
        _destination = dest;
        StartCoroutine(MoveToDestination());
    }

    IEnumerator MoveToDestination()
    {
        while (Vector3.Distance(transform.position, _destination) > 1.0f)
        {
            Vector3.MoveTowards(transform.position, _destination, dropSpeed);
            yield return null;
        }
        rb.useGravity = false;
        yield return null;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Water")
        {
            rb.drag = 10;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour {

	[SerializeField] GameObject fishPrefab;
	[SerializeField] int numFish = 20;
	[SerializeField] GameObject[] _allFish;
	public GameObject[] _AllFish
	{
		get { return _allFish; }
	}
	[SerializeField] Vector3 _swimLimits = new Vector3(5, 5, 5);
	public Vector3 _SwimLimits
	{
		get { return _swimLimits; }
	}

	[SerializeField] Vector3 _goalPos;
	public Vector3 _GoalPos
	{
		get { return _goalPos; }
	}

	[Header("Fish Settings")]
	[Range(0.0f, 5.0f)]
	public float minSpeed;
	[Range(0.0f, 5.0f)]
	public float maxSpeed;
	[Range(1.0f, 10.0f)]
	public float neighbourDistance;
	[Range(0.0f, 5.0f)]
	public float rotationSpeed;

	List<Food> currentFoodPositions = new List<Food>();


	// Use this for initialization
	void Start () {
		_allFish = new GameObject[numFish];
		for(int i = 0; i < numFish; i++)
        {
			Vector3 pos = this.transform.position + new Vector3(Random.Range(-_swimLimits.x, _swimLimits.x),
																Random.Range(-_swimLimits.y, _swimLimits.y),
																Random.Range(-_swimLimits.z, _swimLimits.z));
			_allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
			
			_allFish[i].GetComponent<Flock>().myManager = this;
			_allFish[i].GetComponent<FishCollision>().myManager = this;
		}
		_goalPos = this.transform.position;

		FishFoodContainer.addNewFood += UpdateFoodGoalLocation;
		FishFoodContainer.updateFishFood += UpdateFoodList;

	}



	// Update is called once per frame
	void Update()
	{
		//if (Random.Range(0, 100) < 10)
		//{
		//	goalPos = this.transform.position + new Vector3(Random.Range(-swimLimits.x, swimLimits.x),
		//															Random.Range(-swimLimits.y, swimLimits.y),
		//															Random.Range(-swimLimits.z, swimLimits.z));
		//}
	}

	void UpdateFoodGoalLocation(Food newFood)
    {
		currentFoodPositions.Add(newFood);
	}

	void UpdateFoodList(Food eatenFood)
	{
		currentFoodPositions.Remove(eatenFood);
	}


}

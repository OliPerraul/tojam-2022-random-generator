using System.Collections;
using System.Collections.Generic;
using Cirrus.Unity.Objects;
using UnityEngine;
using UnityEngine.AI;


namespace Tojam2022
{
    public class FishFoodContainer : ToolBase
    {
        public delegate void AddNewFood(Food newLocationFood);
        public static event AddNewFood addNewFood;

        public delegate void UpdateFishFood(Food food);
        public static event UpdateFishFood updateFishFood;

        [SerializeField] float minDropDestinationY;
        [SerializeField] float maxDropDestinationY;

        [SerializeField] List<Food> foods = new List<Food>();

        [SerializeField] GameObject leftSide;
        [SerializeField] GameObject rightSide;
        [SerializeField] GameObject downSide;

        public void Start()
        {
            foreach (Food f in foods)
            {
                if (f == null) continue;
                f._FishFoodContainer = this;
            }
            //StartCoroutine(TestFishFoodContainer());
        }

        //IEnumerator TestFishFoodContainer()
        //{
        //    while (true)
        //    {
        //        yield return new WaitForSeconds(2);
        //        DropFood();
        //    }
        //}

        protected override void _Use()
        {
            Debug.LogWarning("Use Food");
            Debug.LogWarning("x" + gameObject.transform.GetChild(0).transform.position.x);
            Debug.LogWarning("y" + gameObject.transform.GetChild(0).transform.position.y);
            Debug.LogWarning("left" + leftSide.transform.position.x);
            Debug.LogWarning("right" + rightSide.transform.position.x);
            Debug.LogWarning("down" + downSide.transform.position.y);


            if (gameObject.transform.GetChild(0).transform.position.x > leftSide.transform.position.x &&
                gameObject.transform.GetChild(0).transform.position.x < rightSide.transform.position.x &&
                gameObject.transform.GetChild(0).transform.position.y > downSide.transform.position.y)
            {
                if (foods.Count > 0)
                {
                    foods[foods.Count - 1].gameObject.SetActive(true);
                    foods[foods.Count - 1].DropFoodAtDestination(Transform.position,
                        new Vector3(Transform.position.x, Random.Range(minDropDestinationY, maxDropDestinationY), Transform.position.z));
                    addNewFood?.Invoke(foods[foods.Count - 1]);
                    foods.RemoveAt(foods.Count - 1);
                    Debug.LogWarning("Use Food 2");
                }
            }
        }

        public void UpdateFishFoodList(Food food)
        {
            updateFishFood?.Invoke(food);
        }
    }
}
    

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

        private void Start()
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
            if (foods.Count > 0)
            {
                foods[foods.Count - 1].gameObject.SetActive(true);
                foods[foods.Count - 1].DropFoodAtDestination(transform.position,
                    new Vector3(transform.position.x, Random.Range(minDropDestinationY, maxDropDestinationY), transform.position.z));
                addNewFood?.Invoke(foods[foods.Count - 1]);
                foods.RemoveAt(foods.Count - 1);
            }
        }

        public void UpdateFishFoodList(Food food)
        {
            updateFishFood?.Invoke(food);
        }
    }
}
    

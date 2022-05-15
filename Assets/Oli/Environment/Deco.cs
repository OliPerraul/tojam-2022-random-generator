using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cirrus.Events;
using Cirrus.Unity.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Tojam2022
{
	//public class Deco : ScriptableObject
	public class Deco : MonoBehaviour
	{
        //[SerializeField]
        //public GameObject Prefab;

        [SerializeField]
        public string Name = "Seaweed 01";

        [SerializeField]
        public float Price = 10.0f;

        [SerializeField]
        public float Happiness = 10.0f;

        //public Action OnSoldEvent;
    }
}

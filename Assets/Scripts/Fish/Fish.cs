using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
	[SerializeField] int _food;
	public int _Food
	{
		get { return _food; }
		set { _food = value; }
	}

	void Start()
    {
		StartCoroutine(CountDownFood());
    }

	IEnumerator CountDownFood()
	{
		while (true)
		{
			_food--;
			if (_food <= 0)
			{
				//death
				Debug.LogWarning("Death");
			}
			yield return new WaitForSeconds(10);
		}
	}
}

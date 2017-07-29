using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class BodyPartController : MonoBehaviour 
{
	public string id;
	public Transform parent1, parent2;

	void Awake () 
	{
		id = gameObject.name;
	}

	public void TrySetParent(Transform checkedParent)
	{
		if (checkedParent == parent1 || checkedParent == parent2)
			transform.SetParent (checkedParent);
	}
}

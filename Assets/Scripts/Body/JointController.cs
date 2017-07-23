using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class JointController : MonoBehaviour 
{
	public string id;

	void Awake () 
	{
		id = gameObject.name;
	}

	void Update () {
		
	}

	public void DoStep(JointMove move, float time)
	{
		Debug.Log ("JointController DoStep " + move.eularAngles);
		LeanTween.rotate(gameObject, move.eularAngles, time);
	}
}

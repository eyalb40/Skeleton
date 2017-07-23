using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;


public class BodyController : MonoBehaviour 
{
	public BodyData data;
	public BodyActions actions;
	public Dictionary<string, JointController> joints = new Dictionary<string, JointController>();

	void Awake () 
	{
		CollectJoints (transform);
	}
	void Update () {}

	public void DoStep()
	{
		BodyAction action = actions.actions.First (a => a.id == "Walk2Steps");
		if (action == null) 
		{
			Debug.Log ("action is null!");
			return;
		}
		foreach (BodySubAction sa in action.subActions) 
		{
			Debug.Log ("BodyController SubAction=" + sa.id);
			foreach (JointMove move in sa.moves) 
			{
				Debug.Log ("BodyController move=" + move.joint);
				if (joints.ContainsKey(move.joint))
					joints [move.joint].DoStep (move, sa.time);
			}
		}
	}

	private void CollectJoints(Transform transform)
	{
		foreach(Transform child in transform)
		{
			if (child.gameObject.tag == "BodyJoint") 
			{
				joints.Add (child.gameObject.name, child.GetComponent<JointController> ());
				CollectJoints (child);
			}
		}
	}
}

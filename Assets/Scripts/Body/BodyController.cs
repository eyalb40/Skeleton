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

	public IEnumerator SetRootJoint(BodyData.Joints rootJoint)
	{
		Debug.Log ("SetRootJoint: " + rootJoint);
		string jointName = rootJoint.ToString () + "Joint";
		if (!joints.ContainsKey (jointName)) 
		{
			Debug.LogError ("SetRootJoint got illegal joint name: " + jointName);
			yield return null;
		}
		JointController jointC = joints [jointName];
		Transform joint = jointC.transform;
		Transform parent = joint.parent;
		Transform prevParent = joint;
		while (parent != transform && parent != null) 
		{
			Transform nextParent = parent.parent;
			joint.SetParent (nextParent);
			parent.SetParent (prevParent);
			foreach (Transform child in parent)
				if ((child.gameObject.tag == "BodyPart") && (child.GetComponent<BodyPartController>() != null))
					child.GetComponent<BodyPartController>().TrySetParent (prevParent);
			prevParent = parent;
			parent = nextParent;
		}
	}

	public void Walk()
	{
		//DoStep ("OpenStepLeft");
		//DoStep ("FullStepLeft");
		Debug.Log("Walk");
		StartCoroutine(Act());
	}
	public IEnumerator Act()
	{
		Debug.Log("Act");
		yield return StartCoroutine(DoStep ("OpenStepLeft"));
		yield return StartCoroutine(DoStep ("FullStepRight"));
		yield return null;
	}
	public IEnumerator DoStep(string actionId)
	{
		Debug.Log("DoStep "+actionId);
		BodyAction action = actions.actions.First (a => a.id == actionId);
		if (action == null) 
		{
			Debug.Log ("action is null!");
			yield return null;
		}
		foreach (BodySubAction sa in action.subActions) 
		{
			Debug.Log ("BodyController SubAction=" + sa.id);
			yield return StartCoroutine(SetRootJoint (sa.rootJoint));
			foreach (JointMove move in sa.moves) 
			{
				string jointName = move.joint.ToString () + "Joint";
				Debug.Log ("BodyController move=" + jointName);
				if (joints.ContainsKey(jointName))
					joints [jointName].DoStep (move, sa.time);
			}
			yield return new WaitForSeconds (sa.time);
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

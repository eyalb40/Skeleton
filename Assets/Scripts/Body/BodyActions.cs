using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BodyAction 
{
	public string id;
	public List<BodySubAction> subActions;
}



[Serializable]
public class BodySubAction
{
	public string id;
	public float time;
	//public string rootJoint;
	public BodyData.Joints rootJoint;
	public List<JointMove> moves; // JointName,EularAngles
}

[Serializable]
public class JointMove
{
	public BodyData.Joints joint;
	public Vector3 eularAngles;
}

[CreateAssetMenu(menuName="BodyActions", fileName="Assets/Data/BodyActions")]
public class BodyActions : ScriptableObject 
{
	public string id;
	public List<BodyAction> actions;
	public string id2;

}

using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using UnityEngine;

public class SaveBodyData : MonoBehaviour {

	public GameObject body;
	public BodyData data;
	static Type type;

	// Use this for initialization
	public void SaveData()
	{
		int changedFields = 0;
		type = typeof(BodyData);
		foreach(BodyData.Joints joint in Enum.GetValues(typeof(BodyData.Joints)))
		{
			string goString = joint.ToString () + "Joint";
			if (UpdateField (goString, "LocalPosition"))
				changedFields++;
		}
		Debug.Log ("Updated JointLocalPosition: " + changedFields);

		changedFields = 0;
		foreach(BodyData.Parts part in Enum.GetValues(typeof(BodyData.Parts)))
		{
			string goString = part.ToString ();
			if (UpdateField (goString, "LocalScale"))
				changedFields++;
		}
		Debug.Log ("Updated PartLocalScale: " + changedFields);

		changedFields = 0;
		foreach(BodyData.Parts part in Enum.GetValues(typeof(BodyData.Parts)))
		{
			string goString = part.ToString ();
			if (UpdateField (goString, "LocalPosition"))
				changedFields++;
		}
		Debug.Log ("Updated PartLocalPosition: " + changedFields);

		changedFields = 0;
		foreach(BodyData.Parts part in Enum.GetValues(typeof(BodyData.Parts)))
		{
			string goString = part.ToString ();
			if (UpdateField (goString, "EularAngles"))
				changedFields++;
		}
		Debug.Log ("Updated PartLocalPosition: " + changedFields);
	}
	private bool UpdateField(string goString, string fieldSuffix)
	{
		string fieldString = goString + fieldSuffix;
		GameObject go = GameObject.Find (goString);
		FieldInfo field = type.GetField (goString+fieldSuffix);
		if (go == null) 
		{
			Debug.Log("GO not found:  goString = "+goString+ " fieldString="+fieldString);
			return false;
		}
		if (field == null) 
		{
			Debug.Log("Field not found:  goString = "+goString+ " fieldString="+fieldString);
			return false;
		}
		if (fieldSuffix == "LocalPosition")
			field.SetValue (data, go.transform.localPosition);
		else if (fieldSuffix == "LocalScale")
			field.SetValue (data, go.transform.localScale);
		else if (fieldSuffix == "EularAngles")
			field.SetValue (data, go.transform.localEulerAngles);
		return true;
	}
}

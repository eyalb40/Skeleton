using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud : MonoBehaviour {

	public GameObject cameraRotation, cameraLocation, cameraDirection;
	public Text cameraRotationValueText;

	public void Start()
	{
		cameraDirection.transform.LookAt (cameraRotation.transform.position);
	}

	public void OnCameraAngleChanged(float value)
	{
		Vector3 newRotation = cameraRotation.transform.eulerAngles;
		newRotation.y = -value;
		cameraRotation.transform.eulerAngles = newRotation;
		cameraRotationValueText.text = ((int)value).ToString ();
	}
	public void OnCameraZoomChanged(float value)
	{
		Vector3 newLocation = cameraLocation.transform.localPosition;
		newLocation.z = value;
		cameraLocation.transform.localPosition = newLocation;
		cameraDirection.transform.LookAt (cameraRotation.transform.position);
	}
	public void OnCameraHeightChanged(float value)
	{
		Vector3 newLocation = cameraLocation.transform.localPosition;
		newLocation.y = value;
		cameraLocation.transform.localPosition = newLocation;
		cameraDirection.transform.LookAt (cameraRotation.transform.position);
	}
}

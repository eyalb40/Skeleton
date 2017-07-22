using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="BodyData", fileName="Assets/Data/BodyData")]
public class BodyData : ScriptableObject 
{
	public enum Joints { Pelvis, LeftHip, LeftKnee, LeftFoot, LeftToes, RightHip, RightKnee, RightFoot, RightToes, 
		TorsoTop, LeftShoulder, LeftElbow, LeftHand, RightShoulder, RightElbow, RightHand, Neck}
	
	public string id="Default";
	public float totalHeight=0f;
	public float headRadius=0f;

	[Header("Join LocalPositions")]
	// Main
	public Vector3 PelvisJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 TorsoTopJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 NeckJointLocalPosition = new Vector3 (0, 0, 0);
	// LeftLeg
	public Vector3 LeftHipJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 LeftKneeJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 LeftFootJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 LeftToesJointLocalPosition = new Vector3 (0, 0, 0);
	// RightLeg
	public Vector3 RightHipJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 RightKneeJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 RightFootJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 RightToesJointLocalPosition = new Vector3 (0, 0, 0);
	// LeftArm
	public Vector3 LeftShoulderJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 LeftElbowJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 LeftHandJointLocalPosition = new Vector3 (0, 0, 0);
	// RightArm
	public Vector3 RightShoulderJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 RightElbowJointLocalPosition = new Vector3 (0, 0, 0);
	public Vector3 RightHandJointLocalPosition = new Vector3 (0, 0, 0);

	//public Vector3 JointLocation = new Vector3 (0, 0, 0);

	public enum Parts { Pelvis, TorsoTop, TorsoBottom, Neck, LeftLegTop, LeftLegBottom, LeftFoot, RightLegTop, RightLegBottom, RightFoot, 
		LeftShoulder, LeftArmTop, LeftArmBottom1, LeftArmBottom2, LeftHand, RightShoulder, RightArmTop,RightArmBottom1,RightArmBottom2, RightHand, 
		Head }
	
	[Header("BodyPart LocalScales")]
	// Main
	public Vector3 PelvisLocalScale = new Vector3(1f,1f,1f);
	public Vector3 TorsoTopLocalScale = new Vector3(1f,1f,1f);
	public Vector3 TorsoBottomLocalScale = new Vector3(1f,1f,1f);
	public Vector3 NeckLocalScale = new Vector3(1f,1f,1f);
	// LeftLeg
	public Vector3 LeftLegTopLocalScale = new Vector3(1f, 1f, 1f);
	public Vector3 LeftLegBottomLocalScale = new Vector3(1f,1f,1f);
	public Vector3 LeftFootLocalScale = new Vector3(1f,1f,1f);
	// RightLeg
	public Vector3 RightLegTopLocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightLegBottomLocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightFootLocalScale = new Vector3(1f,1f,1f);
	// LeftArm
	public Vector3 LeftShoulderLocalScale = new Vector3(1f,1f,1f);
	public Vector3 LeftArmTopLocalScale = new Vector3(1f,1f,1f);
	public Vector3 LeftArmBottom1LocalScale = new Vector3(1f,1f,1f);
	public Vector3 LeftArmBottom2LocalScale = new Vector3(1f,1f,1f);
	public Vector3 LeftHandLocalScale = new Vector3(1f,1f,1f);
	// RightArm
	public Vector3 RightShoulderLocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightArmTopLocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightArmBottom1LocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightArmBottom2LocalScale = new Vector3(1f,1f,1f);
	public Vector3 RightHandLocalScale = new Vector3(1f,1f,1f);
	// Head
	public Vector3 HeadLocalScale = new Vector3(1f,1f,1f);
	//public Vector3 LocalScale = new Vector3(1f,1f,1f);

	[Header("BodyPart LocalPositions")]
	// Main
	public Vector3 PelvisLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 TorsoTopLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 TorsoBottomLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 NeckLocalPosition = new Vector3(0f,0f,0f);
	// LeftLeg
	public Vector3 LeftLegTopLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftLegBottomLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftFootLocalPosition = new Vector3(0f,0f,0f);
	// RightLeg
	public Vector3 RightLegTopLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightLegBottomLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightFootLocalPosition = new Vector3(0f,0f,0f);
	// LeftArm
	public Vector3 LeftShoulderLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftArmTopLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftArmBottom1LocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftArmBottom2LocalPosition = new Vector3(0f,0f,0f);
	public Vector3 LeftHandLocalPosition = new Vector3(0f,0f,0f);
	// RightArm
	public Vector3 RightShoulderLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightArmTopLocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightArmBottom1LocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightArmBottom2LocalPosition = new Vector3(0f,0f,0f);
	public Vector3 RightHandLocalPosition = new Vector3(0f,0f,0f);
	// Head
	public Vector3 HeadLocalPosition = new Vector3(0f,0f,0f);

	[Header("BodyPart EularAngles")]
	// Main
	public Vector3 PelvisEularAngles = new Vector3(0f,0f,0f);
	public Vector3 TorsoTopEularAngles = new Vector3(0f,0f,0f);
	public Vector3 TorsoBottomEularAngles = new Vector3(0f,0f,0f);
	public Vector3 NeckEularAngles = new Vector3(0f,0f,0f);
	// LeftLeg
	public Vector3 LeftLegTopEularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftLegBottomEularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftFootEularAngles = new Vector3(0f,0f,0f);
	// RightLeg
	public Vector3 RightLegTopEularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightLegBottomEularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightFootEularAngles = new Vector3(0f,0f,0f);
	// LeftArm
	public Vector3 LeftShoulderEularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftArmTopEularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftArmBottom1EularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftArmBottom2EularAngles = new Vector3(0f,0f,0f);
	public Vector3 LeftHandEularAngles = new Vector3(0f,0f,0f);
	// RightArm
	public Vector3 RightShoulderEularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightArmTopEularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightArmBottom1EularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightArmBottom2EularAngles = new Vector3(0f,0f,0f);
	public Vector3 RightHandEularAngles = new Vector3(0f,0f,0f);
	// Head
	public Vector3 HeadEularAngles = new Vector3(0f,0f,0f);
}

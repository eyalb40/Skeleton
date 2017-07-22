using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateFloor : MonoBehaviour 
{
	public static int floorSizeX=50, floorSizeZ = 50;
	public static float tileSizeX=2f,tileSizeY=0.5f,tileSizeZ=2f;
	[MenuItem("Eyal/Build 4x4 Floor")]
	public static void BuildFloor4x4()
	{
		GameObject floorBase = new GameObject ();
		floorBase.transform.position = Vector3.zero;
		floorBase.name = "Floor_"+floorSizeX+"_"+floorSizeZ+"_randY";
		float firstXLocation = (0.5f - floorSizeX * 0.5f) * tileSizeX;
		float firstZLocation = (0.5f - floorSizeZ * 0.5f) * tileSizeZ;
		for (int fX = 0; fX < floorSizeX; fX++) 
		{
			for (int fZ = 0; fZ < floorSizeZ; fZ++) 
			{
				GameObject tileSpot = new GameObject ();
				tileSpot.name = "Spot_" + fX + "_" + fZ;
				tileSpot.transform.SetParent (floorBase.transform);
				tileSpot.transform.localPosition = new Vector3 (firstXLocation + (tileSizeX * fX), 0f, firstZLocation + (tileSizeZ * fZ));
				GameObject tile = GameObject.CreatePrimitive (PrimitiveType.Cube) as GameObject;
				tile.name = "Tile_" + fX + "_" + fZ;
				tile.transform.SetParent (tileSpot.transform);
				float randY = Random.Range (0f, 0.2f);
				tile.transform.localPosition = new Vector3(0f,-0.5f*tileSizeY+randY,0f);
				tile.transform.localScale = new Vector3 (tileSizeX, tileSizeY, tileSizeZ);
				Rigidbody rb = tile.AddComponent<Rigidbody> ();
				rb.useGravity = false;
				rb.mass = 1000;
				rb.constraints = RigidbodyConstraints.FreezeAll;
			}
		}
		PrefabUtility.CreatePrefab ("Assets/Prefabs/"+floorBase.name+".prefab", floorBase);


	}
}


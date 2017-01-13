using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public GameObject Obstacle;
	public GameObject WallBlock1, WallBlock2;

	public Transform generationPoint;
	public float distanceBetween;


	private float Depth;
	[SerializeField] private GameObject[] getCount;
	private int ObjectCounter;

	// Use this for initialization
	void Start () {
		

		}
			
		
	// Update is called once per frame
	void Update () {

		int WallTag = Random.Range(0,2);

		switch (WallTag) 
		{
		case 0:
			Obstacle = WallBlock1;
			break;
		case 1:
			Obstacle = WallBlock2;
			break;
		}

		getCount = GameObject.FindGameObjectsWithTag ("Obstacle");

		ObjectCounter = getCount.Length;


		if (ObjectCounter < 1)
		{
			//transform.position = new Vector3 (transform.position.x - WallDepth - distanceBetween, transform.position.y, transform.position.z);
			Instantiate (Obstacle, generationPoint.position, generationPoint.rotation);
		}
	}

	/*int ObjectCounter(string ObjectName)
	{
		
	    GameObject[] getCount = GameObject.FindGameObjects (ObjectName);
		int counter = getCount.Length;

		return counter;

	}*/

	//Depth = Obstacle.GetComponent<BoxCollider>().size.x;
}

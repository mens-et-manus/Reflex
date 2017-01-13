using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour {

	public Transform destructionPoint;
	//public GameObject ObstacleToDestroy;

	[SerializeField] private GameObject[] findObstacle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		findObstacle = GameObject.FindGameObjectsWithTag ("Obstacle");

		foreach (GameObject ObstacleToDestroy in findObstacle) 
		{
			if (ObstacleToDestroy.transform.position.x > destructionPoint.position.x)
				Destroy (ObstacleToDestroy);
		}
	}
}

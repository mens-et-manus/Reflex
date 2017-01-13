using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public float speed = 6.0f;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(-10, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);
	}
}

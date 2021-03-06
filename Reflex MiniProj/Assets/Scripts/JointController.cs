﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JointController : MonoBehaviour {

	public float sensitivity;

	public Text HealthText;
	public int damage;
	public Text GameOverText;

	private Rigidbody rb;
	private int HealthValue;   //do not initialize here(won't be effective), but in the start()
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		HealthValue = 100;
		GameOverText.text = "";
		SetCollideText ();

	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);

		rb.AddForce(movement*sensitivity);
	}

	void OnTriggerEnter(Collider other) //other game object, the WallBlock
	{
		if (other.gameObject.CompareTag ("Obstacle"))
		{
			HealthValue -= damage;
			SetCollideText();
		} 
	}

	void SetCollideText()
	{
		if (HealthValue >= 0) 
		{
			HealthText.text = "Health: " + HealthValue.ToString ();
		}
		else
		{
			GameOverText.text = "Game Over!";      //text is the function to print
		}

	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed = 5f;
	public Rigidbody2D rb2d;
	public int life = 3;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.velocity = new Vector2 (speed, 0);
		}
		else if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.velocity = new Vector2 (-speed, 0);
		}
		if (life == 0) 
		{
			print ("Game Over!");
		}

}
}

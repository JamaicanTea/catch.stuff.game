using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
	public GameObject score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}
	void OnCollisionEnter2D (Collision2D point)
	{
		if (point.gameObject.CompareTag ("Player")) {
			Destroy (this.score);
		}
	}
}

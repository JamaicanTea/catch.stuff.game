using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penalty : MonoBehaviour {
	public float destroyMinHeight = -6f;
	public ScoreManager newPoints;

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y < destroyMinHeight)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D point)
	{
		if (point.gameObject.CompareTag ("Player")) 
		{
			point.SendMessage ("DecrementScore");
			Destroy(gameObject);
		}
	}
}

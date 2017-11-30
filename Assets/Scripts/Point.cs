using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(AudioSource))]

public class Point : MonoBehaviour
{
	public float destroyMinHeight = -6f;
	AudioSource pointBleep;
	public AudioClip addPoint;

	void Start()
	{
		pointBleep = GetComponent <AudioSource> ();
	}
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
			pointBleep.PlayOneShot (addPoint,1f); //it does not play
			point.SendMessage ("IncrementScore");
			Destroy(gameObject, 2f);
		}
	}
}

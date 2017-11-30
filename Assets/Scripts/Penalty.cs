using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
	
public class Penalty : MonoBehaviour {
	public float destroyMinHeight = -6f;
	public ScoreManager newPoints;
	public playerMovement playerLife;
	public LifeManager hitDetection;
	AudioSource penaltyBleep;
	public AudioClip penalize;

	void Start ()
	{
		playerLife = GetComponent<playerMovement> ();
		penaltyBleep = GetComponent <AudioSource> ();
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
			penaltyBleep.PlayOneShot  (penalize,1f); //it plays repeatedly for some reason
			point.SendMessage ("DecrementScore");
			point.SendMessage ("GetHit",SendMessageOptions.DontRequireReceiver);//supposed to decrease life whenever its hit
			Destroy(gameObject, 1f);
		}
	}
}

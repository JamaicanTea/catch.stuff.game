using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(AudioClip))]

public class SpeedBuff : MonoBehaviour {
	playerMovement playerScript;
	public float destroyMinHeight = -6f;
	public float speedBuff = 5f;
	AudioSource buffBleep;
	public AudioClip speedUp;

	Coroutine co;

	void Start ()
	{
		buffBleep = GetComponent <AudioSource> ();
	}

	void OnTriggerEnter2D (Collider2D other)//when buff hits player, it boosts the player's speed into 9
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			co = StartCoroutine(BuffSpeed(other));
			buffBleep.PlayOneShot (speedUp);

		}
	}

	IEnumerator BuffSpeed(Collider2D player)//how long the buff lasts
	{
		playerScript = GameObject.Find ("player").GetComponent<playerMovement> (); //getting components from the playerMovement script, particularly speed

		print ("you are buffed!");
		playerScript.speed += speedBuff ;

		yield return new WaitForSeconds (5f);

		playerScript.speed -= speedBuff;
		print ("Time out!");

		co = null;
	}

	void Update () 
	{
		if (transform.position.y < destroyMinHeight && co == null)
		{
			Destroy(gameObject);
		}
	}

}

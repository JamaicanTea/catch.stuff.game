using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour {
	playerMovement playerScript;
	public float destroyMinHeight = -6f;
	public int buffTime = 5;
	public int speedBuff = 5;


	// Use this for initialization
	void Start ()//getting components from the playerMovement script, particularly speed
	{
		playerScript = GameObject.Find ("player").GetComponent<playerMovement> ();
	}
	
	void Update () 
	{
		if (transform.position.y < destroyMinHeight)
		{
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D (Collider2D buff)//when buff hits player, it boosts the player's speed into 9
	{
		if (buff.gameObject.CompareTag ("Player")) 
		{
			StartCoroutine (BuffTimer());
			print ("you are buffed!");
			playerScript.speed = playerScript.speed + speedBuff ;
		}
			
}
	IEnumerator BuffTimer()//how long the buff lasts
	{
		yield return new WaitForSeconds (buffTime);
		RestoreToNormal ();
	}

	void RestoreToNormal()//reverts the player's speed to normal
	{
		playerScript.speed = playerScript.speed - speedBuff ;
		print ("buff stopped!");
	}
}

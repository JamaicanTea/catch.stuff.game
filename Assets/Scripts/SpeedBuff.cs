using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour {
	playerMovement playerScript;
	public float destroyMinHeight = -6f;
	public float speedBuff = 5f;

	Coroutine co;

	void OnTriggerEnter2D (Collider2D other)//when buff hits player, it boosts the player's speed into 9
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			co = StartCoroutine(BuffSpeed(other));
		}
	}

	IEnumerator BuffSpeed(Collider2D player)//how long the buff lasts
	{
		playerScript = GameObject.Find ("player").GetComponent<playerMovement> (); //getting components from the playerMovement script, particularly speed

		print ("you are buffed!");
		playerScript.speed += speedBuff ;

		yield return new WaitForSeconds (3f);

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

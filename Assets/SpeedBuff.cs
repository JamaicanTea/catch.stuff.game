using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour {
	public float destroyMinHeight = -6f;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () 
	{
		if (transform.position.y < destroyMinHeight)
		{
			Destroy(gameObject);
		}
	}
	IEnumerator OnTriggerEnter2D (Collider2D buff)
	{
		if (buff.gameObject.CompareTag ("Player")) 
		{
			print ("you are buffed!");
			yield return new WaitForSeconds (5);
			print ("buff is out!");
		}
			
	}

}

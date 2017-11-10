using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBuff : MonoBehaviour {

	public GameObject buffPrefab;
	public float fallSpeedBuff = 10f;
	public GameObject launchBuff;

	void Start () 
	{

		InvokeRepeating ("DropBuffs", 0f, 0f); //makes sure the objects fall each 2 seconds
	}

	// Update is called once per frame
	void DropBuffs () //function for dropping buffs
	{
		GameObject buffInstance = Instantiate (buffPrefab, launchBuff.transform.position, transform.rotation);
		Rigidbody2D rb = buffInstance.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		buffInstance.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeedBuff;
		buffInstance.gameObject.SetActive (true);
	}

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBuff : MonoBehaviour {

	public GameObject buff;
	public float fallSpeedBuff = 10f;
	public GameObject launchBuff;

	void Start () 
	{

		InvokeRepeating ("DropBuffs", 15f, 15f); //makes sure the objects fall each 2 seconds
	}

	// Update is called once per frame
	void DropBuffs () //function for dropping points/penalty objects
	{
		this.buff = Instantiate (this.buff, launchBuff.transform.position, transform.rotation);
		Rigidbody2D rb = buff.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		buff.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeedBuff;
	}

}


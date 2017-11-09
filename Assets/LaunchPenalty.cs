using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPenalty : MonoBehaviour {
	public GameObject penalty;
	public GameObject launchPenalty;
	public float fallSpeedPen = 10f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("DropPenalty", 0f, 1f); //makes sure the objects fall each 2 seconds
	}

	// Update is called once per frame
	void DropPenalty () //function for dropping points/penalty objects
	{
		penalty = Instantiate (penalty, launchPenalty.transform.position, transform.rotation);
		Rigidbody2D rb = penalty.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		penalty.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeedPen;
	}
}
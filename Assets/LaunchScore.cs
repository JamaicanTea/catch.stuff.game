using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScore : MonoBehaviour
{
	public GameObject scorePrefab;
	public GameObject launchScore;
	public float fallSpeed = 10f;


	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("DropPoints", 0f, 2f); //makes sure the objects fall each 2 seconds
	}
	
	// Update is called once per frame
	void DropPoints () //function for dropping points/penalty objects
	{
		GameObject scoreInstance = Instantiate (scorePrefab, launchScore.transform.position, transform.rotation);
		Rigidbody2D rb = scoreInstance.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		scoreInstance.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeed;
		scoreInstance.gameObject.SetActive (true);
	}
}

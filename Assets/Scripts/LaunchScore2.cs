using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScore2 : MonoBehaviour
{
	public GameObject scorePrefab2;
	public GameObject launchScore2;
	public float fallSpeed2 = 10f;


	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("DropPoints", 0f, 3f); //makes sure the objects fall each 3 seconds
	}

	// Update is called once per frame
	void DropPoints () //function for dropping points/penalty objects
	{
		GameObject scoreInstance2 = Instantiate (scorePrefab2, launchScore2.transform.position, transform.rotation);
		Rigidbody2D rb = scoreInstance2.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		scoreInstance2.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeed2;
		scoreInstance2.gameObject.SetActive (true);
	}
}
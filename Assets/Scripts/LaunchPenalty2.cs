using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPenalty2 : MonoBehaviour {
	public GameObject penaltyPrefab2;
	public GameObject launchPenalty2;
	public float fallSpeedPen2 = 12f;
	public ScoreManager scoreManager;


	// Use this for initialization
	void Start () 
	{
		scoreManager = GetComponent <ScoreManager> ();
		InvokeRepeating ("DropPenalty", 0f, 1.5f); //makes sure the objects fall each 2 seconds
	}

	// Update is called once per frame
	void DropPenalty () //function for dropping points/penalty objects
	{
		GameObject penaltyInstance2 = Instantiate (penaltyPrefab2, launchPenalty2.transform.position, transform.rotation);
		Rigidbody2D rb = penaltyInstance2.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		penaltyInstance2.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeedPen2;
		penaltyInstance2.gameObject.SetActive (true);

	}

}
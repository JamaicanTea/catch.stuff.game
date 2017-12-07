using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPenalty : MonoBehaviour {
	public GameObject penaltyPrefab;
	public GameObject launchPenalty;
	public float fallSpeedPen = 10f;
	public ScoreManager scoreManager;
	public GameObject fallingStuff1;
	public GameObject fallingStuff2;


	// Use this for initialization
	void Start () 
	{
		scoreManager = GetComponent <ScoreManager> ();
		InvokeRepeating ("DropPenalty", 0f, 1f); //makes sure the objects fall each 2 seconds
	}

	// Update is called once per frame
	void DropPenalty () //function for dropping points/penalty objects
	{
		GameObject penaltyInstance = Instantiate (penaltyPrefab, launchPenalty.transform.position, transform.rotation);
		Rigidbody2D rb = penaltyInstance.GetComponent<Rigidbody2D> ();
		Vector2 randomPos = new Vector2 (Random.Range (-7f, 8f), 6.2f); 
		penaltyInstance.transform.position = randomPos;
		rb.velocity = Vector2.down * fallSpeedPen;
		penaltyInstance.gameObject.SetActive (true);

		if(scoreManager.score == scoreManager.score - 1 )
		{
			fallSpeedPen++;
		}	
			
	}
		
}
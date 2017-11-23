using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public Text scoreboard;
	public float score = 0;

	// Use this for initialization
	void Start()//Displays score board
	{
		scoreboard.text = "Points :" +score;
		//score = Mathf.Clamp (score , Mathf.Infinity, 0);//makes sure the score doesnt hit below 0
	}

	void PointsOnBoard () //score board
	{
		scoreboard.text = "Points :" + score;

	}

	public void IncrementScore()//increases player's score	
	{
		score++;
		PointsOnBoard ();
	}

	public void DecrementScore()//penalizes the player's score
	{
		//score = Mathf.Max (0, score - 1);
		score--;
		if (score < 0)
		{
			score = 0;
		}
		PointsOnBoard ();	
	}
		
}

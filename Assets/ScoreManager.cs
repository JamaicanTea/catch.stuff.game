using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	public Text scoreboard;
	public int score = 0;
	int updatedScore;

	// Use this for initialization
	void Start()//Displays score board
	{
		scoreboard.text = "Points :" +score ;
	}
	
	// Update is called once per frame
	void PointsOnBoard () //score board
	{
		scoreboard.text = "Points :" + updatedScore;
	}

	public void IncrementScore()//increases player's score	
	{
		updatedScore = score++;
		PointsOnBoard ();
	}

	public void DecrementScore()//penalizes the player's score
	{
		updatedScore = score--;
		PointsOnBoard ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
	public Text lifeBoard;
	public int lives = 3;

	// Use this for initialization
	void Start()//Displays score board
	{
		lifeBoard.text = "Life :" + lives;
		//score = Mathf.Clamp (score , Mathf.Infinity, 0);//makes sure the score doesnt hit below 0
	}
	void UpdateLifeBoard()
	{
		lifeBoard.text = "Life :" + lives;
	}
	public void GetHit ()//whenever player hits penalty, it deduces the player's life
	{
		lives--;
		if (lives< 0)//makes sure life does not go to negative values
		{
			lives = 0;
		}
		UpdateLifeBoard ();
	}
}

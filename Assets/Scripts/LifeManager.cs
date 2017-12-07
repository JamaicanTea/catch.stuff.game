using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
	public Text lifeBoard;
	public int lives = 3;
	public GameObject reset;
	public GameObject quit;
	public GameObject gameOver;
	Coroutine lose;
	public bool isDead;

	// Use this for initialization
	void Start()//Displays score board
	{
		Time.timeScale = 1;
		lifeBoard.text = "Lives :" + lives;
		//score = Mathf.Clamp (score , Mathf.Infinity, 0);//makes sure the score doesnt hit below 0
	}
	void UpdateLifeBoard()
	{
		lifeBoard.text = "Life :" + lives;
	}
	public void GetHit ()//whenever player hits penalty, it deduces the player's life
	{
		lives--;
		if (lives == 0)//makes sure life does not go to negative values
		{
			isDead = true;
		}
		UpdateLifeBoard ();
	}

	void Update ()
	{
		if (isDead == true)
		{
			gameOver.gameObject.SetActive (true);
			reset.gameObject.SetActive (true);
	        quit.gameObject.SetActive (true);
			Time.timeScale = 0;
		}
	}
}

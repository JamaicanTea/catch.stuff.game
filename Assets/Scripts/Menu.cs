using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	// Use this for initialization
	public void StartGame () 
	{
		Application.LoadLevel (1);
	}
	
	// Update is called once per frame
	public void Restart () 
	{
		Application.LoadLevel (1);
	}

	public void QuitTheGame() 
	{
		Application.Quit();
	}

	public void MainMenu ()
	{
		Application.LoadLevel (0);
	}
}

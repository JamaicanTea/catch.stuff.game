using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text countdown;
	Coroutine timer;
	public GameObject player;
	public GameObject launcherScore1;
	public GameObject launcherScore2;
	public GameObject launcherPen1;
	public GameObject launcherPen2;
	public GameObject launcherBuff;



	// Use this for initialization
	void Awake () 
	{
		Time.timeScale = 1f;
		timer = StartCoroutine (Countdown());
	}
		
	IEnumerator Countdown ()
	{
		player.gameObject.SetActive (false);
		countdown.gameObject.SetActive (true);
		launcherPen1.gameObject.SetActive (false);
		launcherPen2.gameObject.SetActive (false);
		launcherScore1.gameObject.SetActive (false);
		launcherScore2.gameObject.SetActive (false);
		launcherBuff.gameObject.SetActive (false);
		countdown.text = "3";
		yield return new WaitForSeconds (1);
		countdown.text = "2";
		yield return new WaitForSeconds (1);
		countdown.text = "1";
		yield return new WaitForSeconds (1);
		countdown.gameObject.SetActive (false);
		player.gameObject.SetActive (true);
		launcherPen1.gameObject.SetActive (true);
		launcherPen2.gameObject.SetActive (true);
		launcherScore1.gameObject.SetActive (true);
		launcherScore2 .gameObject.SetActive (true);
		launcherBuff.gameObject.SetActive (true);
	}
}

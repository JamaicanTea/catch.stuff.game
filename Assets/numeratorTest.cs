using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numeratorTest : MonoBehaviour {

	void Start()
	{
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		print(Time.time);
		yield return new WaitForSeconds(1);
		print(Time.time);
	}
}
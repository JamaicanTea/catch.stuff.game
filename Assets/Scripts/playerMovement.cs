using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float speed = 5f;
	public Rigidbody2D rb2d;
	public int life = 3;
	public float maxWalkSpd = 20f;

	// Use this for initialization
	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		rb2d.velocity = Vector2.zero;

		if(Input.GetKey(KeyCode.RightArrow))
		{
			rb2d.velocity = new Vector2 (speed, 0);
			rb2d.velocity = new Vector2 (Mathf.Clamp (rb2d.velocity.x, -maxWalkSpd, maxWalkSpd ),rb2d.velocity.y);
		}

		if(Input.GetKey(KeyCode.LeftArrow))
		{
			rb2d.velocity = new Vector2 (-speed, 0);
			rb2d.velocity = new Vector2 (Mathf.Clamp (rb2d.velocity.x, -maxWalkSpd, maxWalkSpd ),rb2d.velocity.y);
		}

		if (life == 0) 
		{
			print ("Game Over!");
		}

}
}

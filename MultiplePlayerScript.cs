using UnityEngine;
using System.Collections;

public class MultiplePlayerScript : MonoBehaviour {
	
	private static bool playerExists;

	// code for destroying duplicates of player that are created when going between levels
	void Start () 
	{
		//getting animator for Characters animation and the rigidbody located on the player
		animation = GetComponent<Animator> ();
		MyRigidbody = GetComponent<Rigidbody> ();

		//if the player exists and has not already gone to this level, then playerExists is true
		if (!playerExists) {
			playerExists = true;
			DontDestoryOnLoad (transform.gameObject);
		} 
		//if there is already a player in the level that already fulfills the above if statement, send the second or third character to the else statement to be destoryed

		else
		{
			Destory (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

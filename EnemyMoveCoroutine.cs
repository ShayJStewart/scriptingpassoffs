using UnityEngine;
using System.Collections;

public class EnemyMoveCoroutine : MonoBehaviour {
	
	public float smoothing = 2f;
	public Transform enemy;

	// code for enemy kill count using a loop
	void Start ()
	{
		StartCoroutine(MyCoroutine(enemy));
	}

	IEnumerator MyCoroutine (Transform enemy)
	{ //this code is used to make sure the enemy moves around until the target is reache aka 'the player' which will then stop the code
		// and send it to the last part of the coroutine
		while (Vector3.Distance (transform.position, enemy.position) > 0.05f) 
		{
			transform.position = Vector3.Lerp (transform.position, enemy.position, smoothing * Time.deltaTime);
			yield return null;
		}//coding for enemy to finish the coroutine and say some funny things
		print ("I found the player!");
		yield return new WaitForSeconds (2f);
		print ("I will now prepare to die.");
	}


}

using UnityEngine;
using System.Collections;

public class Enemiesdie : MonoBehaviour
{
	int CurrentEnemies = 3;

	// code for enemy kill count using a loop
	void Start () {
		while (CurrentEnemies > 0)
		{
			Debug.Log ("I've killed an enemy, Huzzah!");
			CurrentEnemies--;
		}
		Debug.Log ("Yay! I've killed all of them!");
	
	}
}

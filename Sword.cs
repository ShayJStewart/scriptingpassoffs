using UnityEngine;
using System.Collections;

public class Sword : Weapons 
{
	public Sword()
	{
		type = "Sword";
		Debug.Log ("1st Sword constructor Called");
	}

	public Sword(string newType) : base(newType)
	{
		Debug.Log ("2nd Sword Constructor Called");
	}
	//in this script we are telling the program how to determine that a sword is a sword and that it is a weapon
}


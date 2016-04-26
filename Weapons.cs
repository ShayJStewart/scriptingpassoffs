using UnityEngine;
using System.Collections;

public class Weapons 
{

	public class Weapons
	{
		//we are going to determine what to do with the weapon by deciding if it is a sword or a bow
		public string type;

		//first constructor for weapons class
		public Weapons()
		{
			type = "sword";
			Debug.Log("1st Weapons Constructor Called");
		}
		//second constructor
		public Weapons(string newType)
		{
			type = newType;
			Debug.Log("2nd Weapons Constructor Called");
		}
		//main things that each weapon can do act like no matter what child class they are
		public void Swing()
		{
			Debug.Log("The" + type + "has been used.");
		}

		public void Funny()
		{
			Debug.Log("I'm real warrior now!");
		}
	
	}
}

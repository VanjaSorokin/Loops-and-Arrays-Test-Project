using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	//	this is a puublic array of ints. There are 5 total.
	public int[] myIntArray = new int[5];

	//	this is an array of gameObjects. 
	//	How many will be found later.
	public GameObject[] players;



	void Start () 
	{
		//	these are the 5 ints and their values.
		myIntArray[0] =  123;
		myIntArray[1] =  53;
		myIntArray[2] =  7;
		myIntArray[3] =  34;
		myIntArray[4] =  842;



		//	This finds all GameObjects with the tag Player, 
		//	and then adds them to the Array.
		players = GameObject.FindGameObjectsWithTag("Player");



		//	now we can run a ForLoop, that will sort our players by number.
		for(int i = 0; i < players.Length; i++)
		{
			//	I copied this debug.log from the tutorial, 
			//	and am not really sure how it works.
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
	}
}

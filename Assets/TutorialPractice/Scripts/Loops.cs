using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	//Loop Types,
	// * WhileLoop.
	// * DoWhileLoop.
	// * ForLoop.
	// * ForEachLoop.

	//This the starting number of players in the field
	public int playersInTheField = 4;


	public int numEnemies = 3;


	//	**NOTE** all of these can be run in start, 
	//	as we are not attempting to run them every Update.
	void Start () 
	{


		//	This is a While Loop. It will keep running while 
		//	the number of players is greater than zero.
		//	Once the number of players reaches zero it will stop 'Killing' players.
		while(playersInTheField > 0)
		{
			Debug.Log ("A player has died");
			playersInTheField--;
		}




		//This is the bool that controls whether or not the DoWhile will keep running.
		bool shouldContinue = false;

		//This is the start of a DoWhile Loop.
		//This will do whatever is inside the loop,
		//then repeat if the 'While' section asks it to do so.
		do
		{
			print ("Running DoWhile Loop!");
			
		}while(shouldContinue == true);
		//	this will always print at least once, 
		//	even it should continue is changed to true.




		//This is a ForLoop. I'm not 100% sure on the specifics 
		//of how the optional variables are declared here or why....
		//the tutorial explains it, but I don't really get it.
		for(int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Creating enemy number: " + i);
		}




		//This is a ForEachLoop. This includes the use of Arrays.
		//There is a second script that covers Just Arrays.
		//Firstly I have made an Array of strings called 'strings' which has 3 in total.
		string[] strings = new string[3];

		//Here they are listed, and then given a name.
		strings[0] = "First string";
		strings[1] = "Second string";
		strings[2] = "Third string";

		//This then says, for each string in 'strings' print their name.
		foreach(string item in strings)
		{
			print (item);
		}
	}
}

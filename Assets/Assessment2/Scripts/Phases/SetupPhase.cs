using UnityEngine;
using System.Collections;


public class SetupPhase : MonoBehaviour {

	public string TeamName;
	public GameObject[] Characters;

	public CharacterSelected _charSelected;


	// Use this for initialization
	void Start () {
		// This should print to player not to console 
		print ("Some Introductory Text");
		_charSelected = this.gameObject.GetComponent<CharacterSelected>();

		TeamName = "Michowned";

		Characters = GameObject.FindGameObjectsWithTag("Player");

		//sorting alphabetacly would work better here!
		for(int i = 0; i < Characters.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+Characters[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CharacterSetup();

	}


	//This is where the characters have all of their information inputted.
	void CharacterSetup(){
		//Set Up of Character 1 stats.
		if(_charSelected.character1Selected == true){
			Characters[0].name = "Mich";

		}

		if(_charSelected.character2Selected == true){
			Characters[1].name = "Steve";
			
		}

		if(_charSelected.character3Selected == true){
			Characters[2].name = "Godric";
			
		}
	}
}

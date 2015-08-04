using UnityEngine;
using System.Collections;


public class SetupPhase : MonoBehaviour {

	public string TeamName;
	public GameObject[] Characters;
	public GameObject[] Enemies;
	public GameObject EnemyHolder;

	public CharacterSelected _charSelected;

	public Transform Char1NewTransform;
	public Transform Char2NewTransform;
	public Transform Char3NewTransform;

	public GameObject[] Buttons; 
	public GameObject ButtonHolder;

	

	// Use this for initialization
	void Start () {
		// This should print to player not to console 
		print ("Some Introductory Text");
		_charSelected = this.gameObject.GetComponent<CharacterSelected>();

		TeamName = "Michowned";

		Characters = GameObject.FindGameObjectsWithTag("Player");
		Buttons = GameObject.FindGameObjectsWithTag("Button");

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

	void FinishCreatingTeam(){
		MovePlayers();
		BuildEnemies();
		RemoveGui();
	}

	void MovePlayers(){
		Characters[0].transform.position = Char1NewTransform.position;
		Characters[1].transform.position = Char2NewTransform.position;
		Characters[2].transform.position = Char3NewTransform.position;
	}

	void BuildEnemies(){
		EnemyHolder.SetActive(true);

		Enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}

	void RemoveGui(){
		ButtonHolder.SetActive(false);
	}
}

using UnityEngine;
using System.Collections;

public class CharacterStats : MonoBehaviour {


	public GameObject[] Characters;

	//The name of the character
	public string name;
	
	//The base character stats - other character stats will be calculated from these values
	public int stamina;
	public int dexterity;
	public int strength;
	public int energy;
	public int healing;
	
	//The amount of damage that has been taken by this character.
	public int damageTaken;
	
	//The minimum base damage for this character
	public int minDamage;
	
	//The maximum base damage for this character
	public int maxDamage;


	public CharacterTypes _charTypes;
	public CharacterSelected _charSelected;


	// Use this for initialization
	void Start () {
		_charTypes = Camera.main.GetComponent<CharacterTypes>();
		_charSelected = Camera.main.GetComponent<CharacterSelected>();

		Characters = GameObject.FindGameObjectsWithTag("Player");
		
		//sorting alphabetacly would work better here!
		for(int i = 0; i < Characters.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+Characters[i].name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CharacterCheck();
	}

	//This Checks which Character this is, and assigns stats according to Character Type.
	void CharacterCheck(){
		if(_charSelected.character1Selected == true && this.gameObject == Characters[0] && _charTypes.ButtonPressed == true){
			name = _charTypes.name;
			stamina = _charTypes.stamina;
			dexterity = _charTypes.dexterity;
			strength = _charTypes.strength;
			energy = _charTypes.energy;
			healing = _charTypes.healing;
		}
		if(_charSelected.character2Selected == true && this.gameObject == Characters[1] && _charTypes.ButtonPressed == true){
			name = _charTypes.name;
			stamina = _charTypes.stamina;
			dexterity = _charTypes.dexterity;
			strength = _charTypes.strength;
			energy = _charTypes.energy;
			healing = _charTypes.healing;
		}
		if(_charSelected.character3Selected == true && this.gameObject == Characters[2] && _charTypes.ButtonPressed == true){
			name = _charTypes.name;
			stamina = _charTypes.stamina;
			dexterity = _charTypes.dexterity;
			strength = _charTypes.strength;
			energy = _charTypes.energy;
			healing = _charTypes.healing;
		}
	}

	//this is how you select your character
	void OnMouseDown(){
		if(this.gameObject == Characters[0]){
			Camera.main.SendMessage ("SelectCharOne");
		}
		if(this.gameObject == Characters[1]){
			Camera.main.SendMessage ("SelectCharTwo");
		}
		if(this.gameObject == Characters[2]){
			Camera.main.SendMessage ("SelectCharThree");
		}
	}
}

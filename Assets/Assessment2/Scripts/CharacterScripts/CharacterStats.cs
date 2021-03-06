﻿using UnityEngine;
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

	public int attackTurn;

	public bool CanHeal = false;


	public CharacterTypes _charTypes;
	public CharacterSelected _charSelected;


	// Use this for initialization
	void Start () {
		_charTypes = Camera.main.GetComponent<CharacterTypes>();
		_charSelected = Camera.main.GetComponent<CharacterSelected>();

		Characters = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		CharacterCheck();
		AssignDamgePotential();
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
			CanHeal = _charTypes.canHeal;
		}
		if(_charSelected.character2Selected == true && this.gameObject == Characters[1] && _charTypes.ButtonPressed == true){
			name = _charTypes.name;
			stamina = _charTypes.stamina;
			dexterity = _charTypes.dexterity;
			strength = _charTypes.strength;
			energy = _charTypes.energy;
			healing = _charTypes.healing;
			CanHeal = _charTypes.canHeal;
		}
		if(_charSelected.character3Selected == true && this.gameObject == Characters[2] && _charTypes.ButtonPressed == true){
			name = _charTypes.name;
			stamina = _charTypes.stamina;
			dexterity = _charTypes.dexterity;
			strength = _charTypes.strength;
			energy = _charTypes.energy;
			healing = _charTypes.healing;
			CanHeal = _charTypes.canHeal;
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

	void AssignDamgePotential(){
		maxDamage = (((energy + strength)*stamina)/3);
		//I used the max damge in the second eqaution to scale the damages together.
		//I also added -1 to the end of this sum so that it's impossible to be higher then the maxDamage
		minDamage = ((strength + maxDamage /3 )- 1);
	}
}

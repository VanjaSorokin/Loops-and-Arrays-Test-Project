using UnityEngine;
using System.Collections;

public class CharacterTypes : MonoBehaviour {

	
	//The name of the character
	public string name;
	
	//The base character stats - other character stats will be calculated from these values
	public int stamina;
	public int dexterity;
	public int strength;
	public int energy;
	public int healing;
	public bool canHeal = false;

	public bool ButtonPressed = false;
	public float ButtonTimer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ButtonPressStop();
	}


	//Five selectable characters and their stats.
	void TechnoMage(){
		name = "Techno Mage";
		stamina = Random.Range(3,6);
		dexterity = Random.Range(4,8);
		strength = Random.Range(1,6);
		energy = 10;
		healing = 0;
		canHeal = false;
		ButtonPressed = true;
		ButtonTimer = 0.0f;
	}

	void StimBot(){
		name = "Stimbot";
		stamina = Random.Range(1,5);
		dexterity = Random.Range(5,10);
		strength = 1;
		energy = Random.Range(10,20);
		healing = 5;
		canHeal = true;
		ButtonPressed = true;
		ButtonTimer = 0.0f;
	}

	void WarpTheif(){
		name = "Warp Theif";
		stamina = 9;
		dexterity = 9;
		strength = Random.Range(1,4);
		energy = Random.Range(3,6);
		healing = 0;
		canHeal = false;
		ButtonPressed = true;
		ButtonTimer = 0.0f;
	}

	void Cyborg(){
		name = "Cyborg";
		stamina = Random.Range(2,5);
		dexterity = 7;
		strength = Random.Range(4,7);
		energy = Random.Range(5,8);
		healing = 2;
		canHeal = true;
		ButtonPressed = true;
		ButtonTimer = 0.0f;
	}

	void HyperElf(){
		name = "Hyper Elf";
		stamina = Random.Range(1,3);
		dexterity = Random.Range(1,3);
		strength = Random.Range(2,5);
		energy = 15;
		healing = 0;
		canHeal = false;
		ButtonPressed = true;
		ButtonTimer = 0.0f;
	}

	//A timer that stops characters from changing class without pressing a button.
	void ButtonPressStop(){
		ButtonTimer += Time.deltaTime;
		if(ButtonTimer >= 0.2f){
			ButtonTimer = 0.0f;
			ButtonPressed = false;
		}
	}
}

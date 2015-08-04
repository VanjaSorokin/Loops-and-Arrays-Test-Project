using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

	
	public GameObject[] Enemies;
	public GameObject EnemyHolder;
	
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

	public EnemySelected _enemySelected;
	
	
	// Use this for initialization
	void Start () {
		_enemySelected = EnemyHolder.gameObject.GetComponent<EnemySelected>();
		
		Enemies = GameObject.FindGameObjectsWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
		AssignDamgePotential();
	}
	
	//this is how you select your character
	void OnMouseDown(){
		if(this.gameObject == Enemies[0]){
			EnemyHolder.gameObject.SendMessage ("SelectEnemyOne");
		}
		if(this.gameObject == Enemies[1]){
			EnemyHolder.gameObject.SendMessage ("SelectEnemyTwo");
		}
		if(this.gameObject == Enemies[2]){
			EnemyHolder.gameObject.SendMessage ("SelectEnemyThree");
		}
	}

	void AssignDamgePotential(){
		maxDamage = (((energy + strength)*stamina)/3);
		minDamage = ((strength + maxDamage /3 )- 1);
	}
}
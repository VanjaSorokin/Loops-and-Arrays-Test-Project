using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyText : MonoBehaviour {

	public GameObject[] Enemies;
	public GameObject EnemyHolder;
	public GameObject enemySelected;
	public EnemyStats _characterStats;
	public EnemySelected _characterSelected;
	
	Text text;
	
	// Use this for initialization
	void Start () {
		Enemies = GameObject.FindGameObjectsWithTag("Enemy");
		_characterSelected = EnemyHolder.gameObject.GetComponent<EnemySelected>();
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {	
		SelectedEnemy();
		text.text = (_characterStats.name +" :Class"+ "\n"+
		             _characterStats.stamina+" :Stamina"+ "\n"+
		             _characterStats.dexterity+ " :Dexterity" + "\n"+
		             _characterStats.strength+ " :Strength" + "\n"+
		             _characterStats.energy+ " :Energy" + "\n"+
		             _characterStats.healing+" :Healing");
	}
	
	
	void SelectedEnemy(){
		_characterStats = enemySelected.GetComponent<EnemyStats>();
		if(_characterSelected.character1Selected == true){
			enemySelected = Enemies[0];
		}
		if(_characterSelected.character2Selected == true){
			enemySelected = Enemies[1];
		}
		if(_characterSelected.character3Selected == true){
			enemySelected = Enemies[2];
		}
	}
}
using UnityEngine;
using System.Collections;

public class Enemy_Team_Builder : MonoBehaviour {

	public GameObject[] Enemies;
	public CharacterTypes _enemyTypes;
	public int RandomClass;

	// Use this for initialization
	void Start () {
		Enemies = GameObject.FindGameObjectsWithTag("Enemy");
		_enemyTypes = Camera.main.GetComponent<CharacterTypes>();

		//attempting to make a for loop build all of the enemies stats in an array.
		for(int i = 0; i < Enemies.Length; i++)
		{
			RandomClass = Random.Range(0,100);
			if(RandomClass >= 0 && RandomClass <= 19){
				Camera.main.SendMessage("TechnoMage");
			}
			if(RandomClass >= 20 && RandomClass <= 39){
				Camera.main.SendMessage("StimBot");
			}
			if(RandomClass >= 40 && RandomClass <= 59){
				Camera.main.SendMessage("WarpTheif");
			}
			if(RandomClass >= 60 && RandomClass <= 79){
				Camera.main.SendMessage("Cyborg");
			}
			if(RandomClass >= 80 && RandomClass <= 99){
				Camera.main.SendMessage("HyperElf");
			}
			Enemies[i].GetComponent<EnemyStats>().name = _enemyTypes.name;
			Enemies[i].GetComponent<EnemyStats>().stamina = _enemyTypes.stamina;
			Enemies[i].GetComponent<EnemyStats>().dexterity = _enemyTypes.dexterity;
			Enemies[i].GetComponent<EnemyStats>().strength = _enemyTypes.strength;
			Enemies[i].GetComponent<EnemyStats>().energy = _enemyTypes.energy;
			Enemies[i].GetComponent<EnemyStats>().healing = _enemyTypes.healing;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
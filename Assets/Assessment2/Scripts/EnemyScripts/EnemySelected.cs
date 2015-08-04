using UnityEngine;
using System.Collections;

public class EnemySelected : MonoBehaviour {

	public GameObject[] Enemies;
	public Color OriginalColor;
	
	public bool character1Selected = false;
	public bool character2Selected = false;
	public bool character3Selected = false;
	
	
	// Use this for initialization
	void Start () {
		Enemies = GameObject.FindGameObjectsWithTag("Enemy");
		OriginalColor = Enemies[0].renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//Message Recievers. These change which character is selected, and their color
	void SelectEnemyOne(){
		character1Selected = true;
		character2Selected = false;
		character3Selected = false;
		
		Enemies[0].renderer.material.color = Color.red;
		Enemies[1].renderer.material.color = OriginalColor;
		Enemies[2].renderer.material.color = OriginalColor;
	}
	void SelectEnemyTwo(){
		character1Selected = false;
		character2Selected = true;
		character3Selected = false;
		
		Enemies[1].renderer.material.color = Color.red;
		Enemies[0].renderer.material.color = OriginalColor;
		Enemies[2].renderer.material.color = OriginalColor;
	}
	void SelectEnemyThree(){
		character1Selected = false;
		character2Selected = false;
		character3Selected = true;
		
		Enemies[2].renderer.material.color = Color.red;
		Enemies[0].renderer.material.color = OriginalColor;
		Enemies[1].renderer.material.color = OriginalColor;
	}
}
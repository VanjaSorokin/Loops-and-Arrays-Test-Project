using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Text_Display : MonoBehaviour {

	public GameObject[] Characters;
	public GameObject characterSelected;
	public CharacterStats _characterStats;
	public CharacterSelected _characterSelected;

	Text text;

	// Use this for initialization
	void Start () {
		Characters = GameObject.FindGameObjectsWithTag("Player");
		_characterSelected = Camera.main.GetComponent<CharacterSelected>();
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {	
		SelectedChar();
		text.text = ("Class: " + _characterStats.name + "\n"+
		             "Stamina: " + _characterStats.stamina+ "\n"+
		             "Dexterity: " + _characterStats.dexterity+ "\n"+
		             "Strength: " + _characterStats.strength+ "\n"+
		             "Energy: " + _characterStats.energy+ "\n"+
		             "Healing: " + _characterStats.healing);
	}


	void SelectedChar(){
		_characterStats = characterSelected.GetComponent<CharacterStats>();
		if(_characterSelected.character1Selected == true){
			characterSelected = Characters[0];
		}
		if(_characterSelected.character2Selected == true){
			characterSelected = Characters[1];
		}
		if(_characterSelected.character3Selected == true){
			characterSelected = Characters[2];
		}
	}
}
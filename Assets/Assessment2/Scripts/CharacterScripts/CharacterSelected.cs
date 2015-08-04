using UnityEngine;
using System.Collections;

public class CharacterSelected : MonoBehaviour {

	public GameObject[] Characters;
	public Color OriginalColor;

	public bool character1Selected = false;
	public bool character2Selected = false;
	public bool character3Selected = false;


	// Use this for initialization
	void Start () {
		Characters = GameObject.FindGameObjectsWithTag("Player");
		OriginalColor = Characters[0].renderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Message Recievers. These change which character is selected, and their color
	void SelectCharOne(){
		character1Selected = true;
		character2Selected = false;
		character3Selected = false;

		Characters[0].renderer.material.color = Color.blue;
		Characters[1].renderer.material.color = OriginalColor;
		Characters[2].renderer.material.color = OriginalColor;
	}
	void SelectCharTwo(){
		character1Selected = false;
		character2Selected = true;
		character3Selected = false;

		Characters[1].renderer.material.color = Color.blue;
		Characters[0].renderer.material.color = OriginalColor;
		Characters[2].renderer.material.color = OriginalColor;
	}
	void SelectCharThree(){
		character1Selected = false;
		character2Selected = false;
		character3Selected = true;

		Characters[2].renderer.material.color = Color.blue;
		Characters[0].renderer.material.color = OriginalColor;
		Characters[1].renderer.material.color = OriginalColor;
	}
}

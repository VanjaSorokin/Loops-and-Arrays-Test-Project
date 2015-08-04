using UnityEngine;
using System.Collections;

public class Accept_Button : MonoBehaviour {

	public Character_Stat_Holder _StatHolder;


	// Use this for initialization
	void Start () {
		_StatHolder = this.gameObject.GetComponent<Character_Stat_Holder>();
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	// Becuase the strings are not null they are empty space, I've used "" to represent null
	void Accept () {
		if (_StatHolder.Char1Name != "" && _StatHolder.Char2Name != "" && _StatHolder.Char3Name != ""){


			print ("is working");

		}

		else {

			print ("please assign a class to each character");
		}
	}
}

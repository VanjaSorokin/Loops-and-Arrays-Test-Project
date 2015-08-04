using UnityEngine;
using System.Collections;

public class Character_Stat_Holder : MonoBehaviour {

	public GameObject[] Characters;
	public CharacterStats _Char1Stats;
	public CharacterStats _Char2Stats;
	public CharacterStats _Char3Stats;

	//Character 1 stats 
	public string Char1Name;
	public int Char1Stamina;
	public int Char1Dexterity;
	public int Char1Strength;
	public int Char1Energy;
	public int Char1Healing;
	public int Char1DamageTaken;
	public int Char1MinDamage;
	public int Char1MaxDamage;
	public bool Char1CanHeal = false;

	//Character 2 stats
	public string Char2Name;
	public int Char2Stamina;
	public int Char2Dexterity;
	public int Char2Strength;
	public int Char2Energy;
	public int Char2Healing;
	public int Char2DamageTaken;
	public int Char2MinDamage;
	public int Char2MaxDamage;
	public bool Char2CanHeal = false;

	//Character 3 Stats
	public string Char3Name;
	public int Char3Stamina;
	public int Char3Dexterity;
	public int Char3Strength;
	public int Char3Energy;
	public int Char3Healing;
	public int Char3DamageTaken;
	public int Char3MinDamage;
	public int Char3MaxDamage;
	public bool Char3CanHeal = false;

	// Use this for initialization
	void Start () {
		Characters = GameObject.FindGameObjectsWithTag("Player");
		_Char1Stats = Characters[0].GetComponent<CharacterStats>();
		_Char2Stats = Characters[1].GetComponent<CharacterStats>();
		_Char3Stats = Characters[2].GetComponent<CharacterStats>();
	}
	
	// Update is called once per frame
	void Update () {
		Character1Stats ();
		Character2Stats ();
		Character3Stats (); 
	
	}

	void Character1Stats (){
		Char1Name = _Char1Stats.name;
		Char1Stamina = _Char1Stats.stamina;
		Char1Dexterity = _Char1Stats.dexterity;
		Char1Strength = _Char1Stats.strength;
		Char1Energy = _Char1Stats.energy;
		Char1Healing = _Char1Stats.healing;
		Char1DamageTaken = _Char1Stats.damageTaken;
		Char1MinDamage = _Char1Stats.minDamage;
		Char1MaxDamage = _Char1Stats.maxDamage;
		Char1CanHeal = _Char1Stats.CanHeal;
	}

	void Character2Stats (){
		Char2Name = _Char2Stats.name;
		Char2Stamina = _Char2Stats.stamina;
		Char2Dexterity = _Char2Stats.dexterity;
		Char2Strength = _Char2Stats.strength;
		Char2Energy = _Char2Stats.energy;
		Char2Healing = _Char2Stats.healing;
		Char2DamageTaken = _Char2Stats.damageTaken;
		Char2MinDamage = _Char2Stats.minDamage;
		Char2MaxDamage = _Char2Stats.maxDamage;
		Char2CanHeal = _Char2Stats.CanHeal;

	}

	void Character3Stats (){
		Char3Name = _Char3Stats.name;
		Char3Stamina = _Char3Stats.stamina;
		Char3Dexterity = _Char3Stats.dexterity;
		Char3Strength = _Char3Stats.strength;
		Char3Energy = _Char3Stats.energy;
		Char3Healing = _Char3Stats.healing;
		Char3DamageTaken = _Char3Stats.damageTaken;
		Char3MinDamage = _Char3Stats.minDamage;
		Char3MaxDamage = _Char3Stats.maxDamage;
		Char3CanHeal = _Char3Stats.CanHeal;

	}
}

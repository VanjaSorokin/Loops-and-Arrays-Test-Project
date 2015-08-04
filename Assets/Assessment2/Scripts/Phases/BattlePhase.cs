using UnityEngine;
using System.Collections;

public class BattlePhase : MonoBehaviour {

	public PhaseController _phaseController;
	public int CombatPhases = 1;	// 1 = Deciding who will go first.
									// 2 = Choosing action.
									// 3 = Initiating action.

	public int ActionToBePerformed = 1; 	// 1 = Attack
											// 2 = Block
											// 3 = Heal
											// 4 = Hold

	public CharacterStats _pStat1;
	public CharacterStats _pStat2;
	public CharacterStats _pStat3;
	public EnemyStats _eStat1;
	public EnemyStats _eStat2;
	public EnemyStats _eStat3;

	public GameObject[] Players;
	public GameObject[] Enemies;

	public int[] PlayersTurnPoints;
	public int[] ranking;

	public int p1TurnDex;
	public int p2TurnDex;
	public int p3TurnDex;
	public int e1TurnDex;
	public int e2TurnDex;
	public int e3TurnDex;

	public bool GotAgilities = false;

	// Use this for initialization
	void Start () {
		_phaseController = Camera.main.GetComponent<PhaseController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(_phaseController.runningPhaseTwo == true){
			Battle();
			Enemies = GameObject.FindGameObjectsWithTag("Enemy");
			Players = GameObject.FindGameObjectsWithTag("Player");
			for(int c = 0; c < 1; c++)
			{
				StartCoroutine(WaitAndPrint());
			}
		}
	}
	
	//this is where the 3 phases of battle are held
	void Battle(){
		//this phase assigns the characters attack speed, meaning, who will attack first.
		if(CombatPhases == 1 && GotAgilities == true){
			//this decides who will go first with a combination of random chance on top of base Dexterity
			PlayersTurnPoints = new int [] {p1TurnDex + Random.Range(0,10),p2TurnDex + Random.Range(0,10),
											p3TurnDex + Random.Range(0,10),e1TurnDex + Random.Range(0,10),
											e2TurnDex + Random.Range(0,10),e3TurnDex + Random.Range(0,10)};
			_pStat1.attackTurn = PlayersTurnPoints[0];
			_pStat2.attackTurn = PlayersTurnPoints[1];
			_pStat3.attackTurn = PlayersTurnPoints[2];
			_eStat1.attackTurn = PlayersTurnPoints[3];
			_eStat2.attackTurn = PlayersTurnPoints[4];
			_eStat3.attackTurn = PlayersTurnPoints[5]; 	//As you can see I'm having serious trouble sorting the arrays.... 
														//I need to be able to sort in order, but I can't work out how.
			CombatPhases = 2;
		}

		//this phase is the action performing phase. Here they will choose to attack, block, heal, or hold.
		if(CombatPhases == 2){

			for(int i = 0; i < (Players.Length + Enemies.Length); i++)
			{
				ActionToBePerformed = Random.Range (1,5);
				if(ActionToBePerformed == 1){
					print ("Someone wants to Attack");
					//ATTACK
				}
				if(ActionToBePerformed == 2){
					print ("Someone wants to Block");
					//BLOCK
				}
				if(ActionToBePerformed == 3){
					print ("Someone wants to Heal");
					//HEAL
				}
				if(ActionToBePerformed == 4){
					print ("Someone wants Hold");
					//HOLD
					i--;
				}
			}

			print ("running combat phase 2");
			CombatPhases = 3;
		}

		if(CombatPhases == 3){
			for(int i = 0; i < (Players.Length + Enemies.Length); i++)
			{
				ActionToBePerformed = Random.Range (1,5);
				if(ActionToBePerformed == 1){
					print ("Someone is Attacking");
					//ATTACK
				}
				if(ActionToBePerformed == 2){
					print ("Someone is Blocking");
					//BLOCK
				}
				if(ActionToBePerformed == 3){
					print ("Someone is Healing");
					//HEAL
				}
				if(ActionToBePerformed == 4){
					print ("Someone is Holding");
					//HOLD
					i--;
				}
			}
		}
	}

	IEnumerator WaitAndPrint() {
		yield return new WaitForSeconds(0.1f);
		GetAgilities();
	}

	void GetAgilities(){
		//This get's all the dexterity's of every combatant, to stop array out of range error.
		//This is a long winded Bug Fix! :( this is the only way I could get rid of the ArrayOutOfRange Error.
		p1TurnDex = Players[0].GetComponent<CharacterStats>().dexterity;
		p2TurnDex = Players[1].GetComponent<CharacterStats>().dexterity;
		p3TurnDex = Players[2].GetComponent<CharacterStats>().dexterity;
		e1TurnDex = Enemies[0].GetComponent<EnemyStats>().dexterity;
		e2TurnDex = Enemies[1].GetComponent<EnemyStats>().dexterity;
		e3TurnDex = Enemies[2].GetComponent<EnemyStats>().dexterity;


		_pStat1 = Players[0].GetComponent<CharacterStats>();
		_pStat2 = Players[1].GetComponent<CharacterStats>();
		_pStat3 = Players[2].GetComponent<CharacterStats>();
		_eStat1 = Enemies[0].GetComponent<EnemyStats>();
		_eStat2 = Enemies[1].GetComponent<EnemyStats>();
		_eStat3 = Enemies[2].GetComponent<EnemyStats>();
		GotAgilities = true;
	}
}

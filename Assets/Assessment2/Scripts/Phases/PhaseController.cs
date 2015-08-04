using UnityEngine;
using System.Collections;

public class PhaseController : MonoBehaviour {

	//Bools that control the states of the Phases
	public bool phaseOneIsActive = false;
	public bool phaseTwoIsActive = false;
	public bool phaseThreeIsActive = false;
	public bool runningPhaseOne = false;	
	public bool runningPhaseTwo = false;
	public bool runningPhaseThree = false;
	


	// Use this for initialization
	void Start () {
		phaseOneIsActive = true;
	}
	
	// Here we are running the phases only if they are active, and the other two are not.
	void Update () {
		if(phaseOneIsActive == true && !phaseTwoIsActive && !phaseThreeIsActive)
		{
			Phase1();
		}

		if(phaseTwoIsActive == true && !phaseOneIsActive && !phaseThreeIsActive)
		{
			Phase2();
		}

		if(phaseThreeIsActive == true && !phaseOneIsActive && !phaseTwoIsActive)
		{
			Phase3();
		}
	}

	//Phase One is the Setup Phase
	//**NOTE** I attempted to use While Loops to run these, but unity kept crashing. Help.
	void Phase1()
	{
		runningPhaseTwo = false;
		runningPhaseThree = false;

		runningPhaseOne = true;
		print ("P1 Act");
	}

	//Phase Two is the Combat Phase
	void Phase2()
	{
		runningPhaseOne = false;
		runningPhaseThree = false;
		
		runningPhaseTwo = true;
		print ("P2 Act");
	}

	//Phase Three is the Summary Phase
	void Phase3()
	{
		runningPhaseOne = false;
		runningPhaseTwo = false;
		
		runningPhaseThree = true;
		print ("P3 Act");
	}
}
